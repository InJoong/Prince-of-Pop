using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Russle_script : MonoBehaviour {

	public Animator Animator;
	public bool isPlayerNear; 
	public float Health;
	public GameObject Bullet;
	GameObject Bullet_clone;
	public GameObject SpawnerPosition;

	// Use this for initialization
	void Start () {
		isPlayerNear = false;
		Health=5;
		
	}
	
	// Update is called once per frame
	void Update () {

		Animator.SetBool("isPlayerNear", isPlayerNear);

	}
void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 10)
        {
            Debug.Log("Hit");
            Health -= other.gameObject.GetComponent<Projectile>().Damage;
        }

        if (other.gameObject.layer == 8)
        {
            isPlayerNear = true;
			Invoke("shoot", 4);
        }
    }

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.layer ==8){
			isPlayerNear = false;
		}
	}

	void shoot(){
		if(isPlayerNear){
			Invoke("shoot",4);
		}
		Bullet_clone= Instantiate(Bullet,SpawnerPosition.transform.position,Quaternion.identity) as GameObject;
		Destroy(Bullet_clone,3);
	}

}
