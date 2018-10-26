using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyModel))]
public class EnemyAI : MonoBehaviour {

    private EnemyModel eneModel;

    [SerializeField] private float distance = 10.0f;
    [SerializeField] private Collider2D detectionCollider;
    [SerializeField] private bool foundPlayer = false;

    private GameObject player;
    private float tempTime = 0;

    private float health = 5.0f;

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

        if (this.health <= 0)
            Destroy(gameObject);

        if (foundPlayer)
            followPlayer();

        if (!foundPlayer)
        {
            //Temp
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
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 10)
        {
            Debug.Log("Hit");
            health -= other.gameObject.GetComponent<Projectile>().Damage;
        }

        if (other.gameObject.layer == 8)
        {
            foundPlayer = true;
            player = other.gameObject;
        }
    }

    public void followPlayer()
    {
        if (player.transform.position.x - transform.position.x > 0.1)
        {
            this.transform.position += new Vector3(eneModel.Speed, 0, 0) * Time.deltaTime;

            if (!eneModel.FacingRigth)
                FlipCharacter();
        }
        else if (player.transform.position.x - transform.position.x < -0.1)
        {
            this.transform.position += new Vector3(-eneModel.Speed, 0, 0) * Time.deltaTime;
            
            if (eneModel.FacingRigth)
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
}
