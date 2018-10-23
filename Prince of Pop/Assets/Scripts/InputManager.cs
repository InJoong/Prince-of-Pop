using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    void Start()
    {
        ScriptManager.singleton.InputManager = this;
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
        //Horizontal Movement
        ScriptManager.singleton.PlayerManager.CharMovement.Move(new Vector2(ScriptManager.singleton.PlayerManager.CharModel.MovementSpeed 
                                                    * Input.GetAxisRaw("Horizontal"), 0));

        //Jump
        if (Input.GetKeyDown("x") && !ScriptManager.singleton.PlayerManager.CharModel.Damaged)
            ScriptManager.singleton.PlayerManager.CharMovement.Jump();

        //Shoot
        if (Input.GetKeyDown("c") && !ScriptManager.singleton.PlayerManager.CharModel.Damaged)
        {
            ScriptManager.singleton.PlayerManager.CharAction.IntantiateProjectile(ScriptManager.singleton.PlayerManager.CharModel.FacingRigth);
        }

        if (Input.GetKeyDown("z") && !ScriptManager.singleton.PlayerManager.CharModel.Damaged)
        {
            ScriptManager.singleton.PlayerManager.CharInteraction.GrabWeapon();
        }
        
        //Flip texture
        if (Input.GetAxis("Horizontal") > 0 && !ScriptManager.singleton.PlayerManager.CharModel.FacingRigth && !ScriptManager.singleton.PlayerManager.CharModel.Damaged)
            FlipCharacter();
        else if (Input.GetAxis("Horizontal") < 0 && ScriptManager.singleton.PlayerManager.CharModel.FacingRigth && !ScriptManager.singleton.PlayerManager.CharModel.Damaged)
            FlipCharacter();
    }

    public void FlipCharacter()
    {
        ScriptManager.singleton.PlayerManager.CharModel.FacingRigth = !ScriptManager.singleton.PlayerManager.CharModel.FacingRigth;
        Vector3 imageScale = this.transform.localScale;
        imageScale.x *= -1;
        this.gameObject.transform.localScale = imageScale;
    }

    private void OnGUI()
    {
        GUILayout.Label("Hp| "+ ScriptManager.singleton.PlayerManager.CharModel.Health+" |");
    }
}
