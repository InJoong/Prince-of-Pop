using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponModel : MonoBehaviour {

    [SerializeField] private float damage = 10;
    [SerializeField] private float speed = 10;
    [SerializeField] private float range = 10;
    [SerializeField] private GameObject projectile;

    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public float Range
    {
        get
        {
            return range;
        }

        set
        {
            range = value;
        }
    }

    public GameObject Projectile
    {
        get
        {
            return projectile;
        }

        set
        {
            projectile = value;
        }
    }
}
