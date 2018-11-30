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

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9 || collision.gameObject.layer == 12)
        {
            if (!playerManager.CharState.Damaged && !playerManager.CharState.Invinsible)
            {
                playerManager.CharState.DecreaseHealth(collision.gameObject.GetComponent<EnemyModel>().Attack);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Interactable>() != null)
        {
            transform.Find("Action Button").GetComponent<SpriteRenderer>().enabled = true;
            objectoToInteract = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        objectoToInteract = null;
        if (collision.GetComponent<Interactable>() != null)
        {
            transform.Find("Action Button").GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
