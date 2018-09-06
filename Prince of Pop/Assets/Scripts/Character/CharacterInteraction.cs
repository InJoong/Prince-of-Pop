using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour {

    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject projectileOrigin;

    [SerializeField] private float bulletSpeed = 2000.0f;

	public void IntantiateProjectile(bool rigth)
    {
        GameObject bullet = Instantiate(projectile, projectileOrigin.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        Vector3 imageScale = this.transform.localScale;
        bullet.transform.localScale = imageScale;
        bullet.name="bullet";

        if (!rigth) {
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-bulletSpeed, 0));
        }
        else
        {
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 0));
        }
    }

}
