﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{

    [SerializeField] private float health = 10.0f;
    [SerializeField] private float movementSpeed = 10.0f;
    [SerializeField] private float jumpForce = 10.0f;
    [SerializeField] private bool facingRigth = true;
    [SerializeField] private bool invisible = false;
    [SerializeField] private bool damaged = false;

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

    public bool Invisible
    {
        get
        {
            return invisible;
        }

        set
        {
            invisible = value;
        }
    }

    public bool Damaged
    {
        get
        {
            return damaged;
        }

        set
        {
            damaged = value;
        }
    }
}