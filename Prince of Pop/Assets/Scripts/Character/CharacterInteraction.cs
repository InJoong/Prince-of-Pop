using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour {

    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject projectileOrigin;

    [SerializeField] private float bulletSpeed = 100000.0f;

	public void IntantiateProjectile(bool rigth)
    {
        GameObject bullet = Instantiate(projectile, projectileOrigin.transform.position, projectileOrigin.transform.rotation);
        Vector3 temp = bullet.transform.localScale;
        temp.x *= true ? 1 : -1;
        bullet.transform.localScale = temp;
        Rigidbody2D bulletRigidbody = bullet.GetComponent<Rigidbody2D>();

        
        
        bulletRigidbody.AddForce(bullet.transform.forward * 10000);
    }

}
