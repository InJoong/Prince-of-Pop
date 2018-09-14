using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    private Rigidbody2D rigBody2d;
    private CharacterManager charManager;

    private void Start()
    {
        rigBody2d = GetComponent<Rigidbody2D>();
        charManager = GetComponent<CharacterManager>();
    }

    public void Move(float x)
    {
        gameObject.transform.Translate(charManager.CharModel.MovementSpeed * x, 0, 0);
    }

    public void Jump()
    {
        this.rigBody2d.AddForce(new Vector2(0, charManager.CharModel.JumpForce));
    }
}
