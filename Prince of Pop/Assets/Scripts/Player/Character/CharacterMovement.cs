using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    private Rigidbody2D rigBody2d;
    private PlayerManager playerManager;

    private bool grounded;

    [SerializeField] Transform groundCheck;
    [SerializeField] private LayerMask checkLayer;
    [SerializeField] Vector2 groundSize;

    private void Start()
    {
        rigBody2d = GetComponent<Rigidbody2D>();
        playerManager = GetComponent<PlayerManager>();
    }

    void Update()
    {
        Grounded = Physics2D.OverlapBox(groundCheck.position, groundSize, 0, checkLayer);
    }

    public void Move(Vector2 move)
    {
        this.gameObject.transform.Translate(move.x, 0, 0);

        /*
        Vector2 move = Vector2.zero;
        move.x = playerManager.CharModel.MovementSpeed * x;
        rigBody2d.position += move;
        */
    }

    public void Jump()
    {
        if(Grounded)
            this.rigBody2d.AddForce(new Vector2(0, playerManager.CharModel.JumpForce));
    }

    public bool Grounded
    {
        get
        {
            return grounded;
        }

        set
        {
            grounded = value;
        }
    }
}
