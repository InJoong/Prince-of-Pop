using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSign : MonoBehaviour, Interactable {

    [SerializeField] SpriteRenderer controlWindow;

    public void Interact()
    {
        if (controlWindow.enabled == false)
        {
            controlWindow.enabled = true;
        }
        else
        {
            controlWindow.enabled = false;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        controlWindow.enabled = false;
    }
}
