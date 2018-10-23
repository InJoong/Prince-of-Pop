using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponContainer : MonoBehaviour {

    [SerializeField] GameObject weapon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            Rigidbody2D rigid = GetComponent<Rigidbody2D>();

            rigid.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }

    public GameObject Weapon
    {
        get
        {
            return weapon;
        }

        set
        {
            weapon = value;
        }
    }
}
