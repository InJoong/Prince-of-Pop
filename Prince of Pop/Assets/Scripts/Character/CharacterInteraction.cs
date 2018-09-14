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

    }

    public void Damaged(bool facingRigth)
    {
        if(!facingRigth)
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500, 100));
        if (facingRigth)
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500, 100));
    }

}
