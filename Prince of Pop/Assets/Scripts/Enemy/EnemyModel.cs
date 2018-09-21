using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : MonoBehaviour {

    [SerializeField] private float health = 100.0f;
    [SerializeField] private float attack = 10.0f;
    [SerializeField] private float defense = 10.0f;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private bool facingRigth = true;

    public float Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public float Attack
    {
        get
        {
            return attack;
        }

        set
        {
            attack = value;
        }
    }

    public float Defense
    {
        get
        {
            return defense;
        }

        set
        {
            defense = value;
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

    public bool FacingRigth
    {
        get
        {
            return facingRigth;
        }

        set
        {
            facingRigth = value;
        }
    }
}
