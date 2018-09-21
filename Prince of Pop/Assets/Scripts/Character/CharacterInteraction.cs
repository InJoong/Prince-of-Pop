using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour {

    private CharacterManager charManager;

    void Awake()
    {
        charManager = GetComponent<CharacterManager>();
    }

    public void Interaction()
    {
<<<<<<< HEAD
        GameObject bullet = Instantiate(projectile, projectileOrigin.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        Vector3 imageScale = this.transform.localScale;
        bullet.transform.localScale = imageScale;
        bullet.name="bullet";
=======
>>>>>>> InJoong

    }

    public void Damaged(bool facingRigth)
    {
        if(!facingRigth)
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500, 100));
        if (facingRigth)
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500, 100));
    }

}
