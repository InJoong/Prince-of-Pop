using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rigBody2d;
    private CharacterMovement charMovement;
    private CharacterModel charModel;
    private CharacterInteraction charIntetaction;

    [SerializeField] Transform groundCheck;
    [SerializeField] private LayerMask checkLayer;
    [SerializeField] Vector2 groundSize;
    [SerializeField] float jumpForce = 300.0f;
   
    private bool grounded;

    void Start () {
        rigBody2d = GetComponent<Rigidbody2D>();
        charMovement = GetComponent<CharacterMovement>();
        charModel = GetComponent<CharacterModel>();
        charIntetaction = GetComponent<CharacterInteraction>();
    }
    /*
	void FixedUpdate () {
        grounded = Physics2D.OverlapBox(groundCheck.position, groundSize, 0, checkLayer);
        float move = Input.GetAxis("Horizontal");
        
        rigBody2d.velocity = new Vector2(move * charModel.MovementSpeed, rigBody2d.velocity.y);

        if (grounded && Input.GetButtonDown("Jump"))
        {
            rigBody2d.AddForce(new Vector2(0, jumpForce));
        }

        if (move > 0 && !facingRigth)
            FlipCharacter();
        else if(move < 0 && facingRigth)
            FlipCharacter();
    }
    */
    void Update()
    {
        grounded = Physics2D.OverlapBox(groundCheck.position, groundSize, 0, checkLayer);
        Debug.Log(grounded);

        if (Input.GetButton("Right"))
            charMovement.Move(charModel.MovementSpeed);
        if (Input.GetButton("Left"))
            charMovement.Move(-charModel.MovementSpeed);

        if (grounded && Input.GetButtonDown("Jump"))
            rigBody2d.AddForce(new Vector2(0, jumpForce));

        if (Input.GetButtonDown("Fire"))
        {
            charIntetaction.IntantiateProjectile(charModel.FacingRigth);
        }

        if (Input.GetAxis("Horizontal") > 0 && !charModel.FacingRigth)
            FlipCharacter();
        else if (Input.GetAxis("Horizontal") < 0 && charModel.FacingRigth)
            FlipCharacter();
    }
    public void FlipCharacter()
    {
        charModel.FacingRigth = !charModel.FacingRigth;
        Vector3 imageScale = this.transform.localScale;
        imageScale.x *= -1;
        this.gameObject.transform.localScale = imageScale;
    }
}
