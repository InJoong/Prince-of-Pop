using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour, Interactable {

    [SerializeField] private Sprite scored;

    void Start()
    {
        if (ScriptManager.singleton.SceneController.StartName == "Check Point")
        {
            GetComponent<SpriteRenderer>().sprite = scored;
        }
    }

	public void Interact()
    {
        if (ScriptManager.singleton.SceneController.StartName == "Start Point")
        {
            ScriptManager.singleton.SceneController.StartName = "Check Point";
            GetComponent<SpriteRenderer>().sprite = scored;
        }
    }
}
