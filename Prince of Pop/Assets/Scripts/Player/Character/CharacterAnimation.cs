using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour {

    private Animator characterAnimator;

    private PlayerManager playerManager;

    // Use this for initialization
    void Start () {
        playerManager = GetComponent<PlayerManager>();
        characterAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        characterAnimator.SetFloat("SpeedX", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        characterAnimator.SetFloat("SpeedY", this.gameObject.GetComponent<Rigidbody2D>().velocity.y);
        characterAnimator.SetFloat("Health", playerManager.CharState.CurrentHealth);
        characterAnimator.SetBool("Grounded", playerManager.CharMovement.Grounded);
        characterAnimator.SetBool("Damaged", playerManager.CharState.Damaged);
        
    }

    public void ShootingAnimation()
    {
        characterAnimator.SetTrigger("Shoot");
    }
}
