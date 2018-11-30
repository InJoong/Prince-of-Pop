using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boo : MonoBehaviour {

    private EnemyModel eneModel;

    [SerializeField] private float detectionRadius = 20;
    [SerializeField] private float detectionDistance = 10;
    [SerializeField] private LayerMask detectionMask;

    private Transform player;
    private float health = 5.0f;

    private float countTime = 0;

    void Awake()
    {
        eneModel = GetComponent<EnemyModel>();
    }

    void Start()
    {
        health = eneModel.Health;
    }

    void Update()
    {

        if (health <= 0)
            Destroy(gameObject);

        RaycastHit2D hit = Physics2D.CircleCast(transform.position, detectionRadius, new Vector2(1, 1), detectionDistance, detectionMask);
        if (hit.collider != null)
        {
            countTime += Time.deltaTime;

            player = hit.collider.transform;

            FollowPlayer(player);
        }

    }

    public void FollowPlayer(Transform player)
    {

        this.transform.position = Vector2.MoveTowards(transform.position, player.position, eneModel.Speed*Time.deltaTime);

        if (transform.position.x - player.position.x > 0 && !eneModel.FacingRigth)
        {
            FlipCharacter();
        }
        else if (transform.position.x - player.position.x < 0 && eneModel.FacingRigth)
        {
            FlipCharacter();
        }
    }

    public void FlipCharacter()
    {
        eneModel.FacingRigth = !eneModel.FacingRigth;
        Vector3 imageScale = this.transform.localScale;
        imageScale.x *= -1;
        this.gameObject.transform.localScale = imageScale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 10)
        {
            health -= other.gameObject.GetComponent<Projectile>().Damage;
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            Invoke("Undamaged", 0.8f);
        }
    }

    public void Undamaged()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
