using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_A : MonoBehaviour, WeaponInteraction {

    [SerializeField] private float damage = 10;
    [SerializeField] private float speed = 10;
    [SerializeField] private float range = 10;
    [SerializeField] private GameObject projectile;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Interaction(bool rigth, Vector3 position)
    {
        GameObject bullet = Instantiate(projectile, position, Quaternion.Euler(new Vector3(0, 0, 0)));
        bullet.GetComponent<Projectile>().Damage = damage;
        Vector3 imageScale = this.transform.localScale;
        bullet.transform.localScale = imageScale;

        if (!rigth)
        {
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
        }
        else
        {
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        }
    }
}
