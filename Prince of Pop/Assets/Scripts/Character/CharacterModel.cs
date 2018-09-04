using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour {

    [SerializeField] private float movementSpeed = 10.0f;
    [SerializeField] private float jumpForce = 10.0f;
    [SerializeField] private bool facingRigth = true;

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
}
