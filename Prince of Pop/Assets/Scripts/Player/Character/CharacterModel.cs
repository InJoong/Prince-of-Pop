using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{

    [SerializeField] private float health = 10.0f;
    [SerializeField] private float movementSpeed = 10.0f;
    [SerializeField] private float jumpForce = 10.0f;
    [SerializeField] private GameObject projectileOrigin;

    public float MovementSpeed
    {
        get
        {
            return movementSpeed;
        }

        set
        {
            movementSpeed = value;
        }
    }

    public float JumpForce
    {
        get
        {
            return jumpForce;
        }

        set
        {
            jumpForce = value;
        }
    }

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

    public GameObject ProjectileOrigin
    {
        get
        {
            return projectileOrigin;
        }

        set
        {
            projectileOrigin = value;
        }
    }
}
