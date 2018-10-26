using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour {

    private PlayerManager playerManager;
    private GameObject objectoToInteract;

    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
    }

    public void InteractObject()
    {
        if (objectoToInteract != null) {
            objectoToInteract.GetComponent<Interactable>().Interact();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            if (!playerManager.CharState.Damaged)
            {
                Debug.Log("Enemy");
                playerManager.CharState.DecreaseHealth(collision.gameObject.GetComponent<EnemyModel>().Attack);
                playerManager.CharState.KnockBack();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Interactable>() != null)
        {
            objectoToInteract = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        objectoToInteract = null;
    }
}
