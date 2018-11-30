using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Russle_script : MonoBehaviour {

    private EnemyModel eneModel;

    [SerializeField] private float detectionRadius = 20;
    [SerializeField] private float detectionDistance = 10;
    [SerializeField] private LayerMask detectionMask;
    [SerializeField] private float shootSpeed = 4.0f;
    [SerializeField] private GameObject SpawnerPosition;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Animator Animator;

    private Transform player;
    private float health = 5.0f;
	private bool isPlayerNear;

    private float countTime = 0;

    void Awake()
    {
        eneModel = GetComponent<EnemyModel>();
    }

    // Use this for initialization
    void Start () {
		isPlayerNear = false;
        health = eneModel.Health;
    }
	
	// Update is called once per frame
	void Update () {

        if (health <= 0)
            Destroy(gameObject);

        Animator.SetBool("isPlayerNear", isPlayerNear);

        RaycastHit2D hit = Physics2D.CircleCast(transform.position, detectionRadius, new Vector2(1, 1), detectionDistance, detectionMask);
        if (hit.collider != null)
        {
            countTime += Time.deltaTime;

            player = hit.collider.transform;

            FollowPlayer();

            isPlayerNear = true;

            if (countTime >= shootSpeed)
            {
                Shoot();
                countTime = 0;
            }
        }
        else
        {
            isPlayerNear = false;
        }

	}

    public void FollowPlayer()
    {
        if (player.position.x - transform.position.x > 0.1)
        {
            this.transform.position += new Vector3(eneModel.Speed, 0, 0) * Time.deltaTime;
        }
        else if (player.position.x - transform.position.x < -0.1)
        {
            this.transform.position += new Vector3(-eneModel.Speed, 0, 0) * Time.deltaTime;
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

    public void Shoot(){
		Instantiate(Bullet,SpawnerPosition.transform.position,Quaternion.identity);
	}

}
