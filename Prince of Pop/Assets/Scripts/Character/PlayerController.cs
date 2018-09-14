using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    
    private CharacterManager charManager;
    private Animator characterAnimator;

    [SerializeField] Transform groundCheck;
    [SerializeField] private LayerMask checkLayer;
    [SerializeField] Vector2 groundSize;
   
    private bool grounded;
    private float damageTime = 0;

    void Awake () {
        charManager = GetComponent<CharacterManager>();
        characterAnimator = GetComponent<Animator>();
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

        if (Input.GetKey("right") && !charManager.CharModel.Damaged)
            charManager.CharMovement.Move(1);
        if (Input.GetKey("left") && !charManager.CharModel.Damaged)
            charManager.CharMovement.Move(-1);

        if (grounded && Input.GetKeyDown("space") && !charManager.CharModel.Damaged)
            charManager.CharMovement.Jump();

        if (Input.GetKeyDown("z") && !charManager.CharModel.Damaged)
        {
            charManager.CharAction.IntantiateProjectile(charManager.CharModel.FacingRigth);
        }

        if (Input.GetAxis("Horizontal") > 0 && !charManager.CharModel.FacingRigth && !charManager.CharModel.Damaged)
            FlipCharacter();
        else if (Input.GetAxis("Horizontal") < 0 && charManager.CharModel.FacingRigth && !charManager.CharModel.Damaged)
            FlipCharacter();

        if (charManager.CharModel.Damaged)
        {
            damageTime += Time.deltaTime;

            if (damageTime >= 0.6f)
            {
                charManager.CharModel.Damaged = false;
                damageTime = 0;
            }
        }

        characterAnimator.SetFloat("SpeedX", Mathf.Abs(Input.GetAxis("Horizontal")));
        characterAnimator.SetFloat("SpeedY", this.gameObject.GetComponent<Rigidbody2D>().velocity.y);
        characterAnimator.SetBool("Grounded", grounded);
    }

    public void FlipCharacter()
    {
        charManager.CharModel.FacingRigth = !charManager.CharModel.FacingRigth;
        Vector3 imageScale = this.transform.localScale;
        imageScale.x *= -1;
        this.gameObject.transform.localScale = imageScale;
    }

    private void OnGUI()
    {
        GUILayout.Label("Hp| "+charManager.CharModel.Health+" |");
    }
}
