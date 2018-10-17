using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour {

    private PlayerManager playerManager;

    void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
    }

    public void Interaction()
    {

    }

    public void Damaged(bool facingRigth)
    {
        if(!facingRigth)
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500, 100));
        if (facingRigth)
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500, 100));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            if (!playerManager.CharModel.Damaged)
            {
                Debug.Log("Enemy");
                playerManager.CharState.DecreaseHealth(collision.gameObject.GetComponent<EnemyModel>().Attack);
                Damaged(collision.gameObject.GetComponent<EnemyModel>().FacingRigth);
                playerManager.CharModel.Damaged = true;
            }
        }
    }
}
