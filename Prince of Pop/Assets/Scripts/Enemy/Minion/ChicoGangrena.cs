using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyModel))]
public class ChicoGangrena : MonoBehaviour {

    private EnemyModel eneModel;

    [SerializeField] private float followDistance = 20.0f;
    [SerializeField] private float detectionDistance = 5.0f;
    [SerializeField] private LayerMask detectionMask;
    [SerializeField] private bool foundPlayer = false;

    private float tempTime = 0;
    private Transform player;
    private float health = 5.0f;
    private RaycastHit2D hit;

    // Use this for initialization
    void Awake () {
        eneModel = GetComponent<EnemyModel>();
    }

    void Start()
    {
        health = eneModel.Health;
    }

    void Update () {
        //Temp
        tempTime += Time.deltaTime;

        if (health <= 0)
            Destroy(gameObject);

        if (foundPlayer)
        {
            FollowPlayer();

            player = GameObject.Find("Character").transform;

            if (Vector2.Distance(transform.position, player.position) > followDistance)
            {
                foundPlayer = false;
            }

            
        }
        else
        {
            Unalarmed();

            hit = Physics2D.Raycast(transform.position, new Vector2(transform.localScale.x, 0), detectionDistance, detectionMask);
            
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.layer == 8)
                {
                    foundPlayer = true;
                    player = hit.transform;
                }
            }
        }
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

    public void FollowPlayer()
    {
        if (player.position.x - transform.position.x > 0.1)
        {
            this.transform.position += new Vector3(eneModel.Speed, 0, 0) * Time.deltaTime;

            if (!eneModel.FacingRigth)
                FlipCharacter();
        }
        else if (player.position.x - transform.position.x < -0.1)
        {
            this.transform.position += new Vector3(-eneModel.Speed, 0, 0) * Time.deltaTime;
            
            if (eneModel.FacingRigth)
                FlipCharacter();
        }
    }

    public void Unalarmed()
    {
        if (tempTime <= 2)
        {
            this.transform.position += new Vector3(eneModel.Speed, 0, 0) * Time.deltaTime;

            if (!eneModel.FacingRigth)
                FlipCharacter();
        }
        else
        {
            this.transform.position += new Vector3(-eneModel.Speed, 0, 0) * Time.deltaTime;

            if (eneModel.FacingRigth)
                FlipCharacter();
        }
        if (tempTime > 4)
            tempTime = 0;

    }

    public void FlipCharacter()
    {
        eneModel.FacingRigth = !eneModel.FacingRigth;
        Vector3 imageScale = this.transform.localScale;
        imageScale.x *= -1;
        this.gameObject.transform.localScale = imageScale;
    }
}
