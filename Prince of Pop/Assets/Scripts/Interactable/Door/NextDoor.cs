using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextDoor : MonoBehaviour, Interactable {

    [SerializeField] private int scene = 2;

	public void Interact()
    {
        ScriptManager.singleton.SceneController.NextLevel = scene;
        ScriptManager.singleton.SceneController.StartName = "Start Point";

        if (SceneManager.GetActiveScene().name != "Outtro")
        {
            Cursor.visible = true;
        }

        SceneManager.LoadScene(scene);
    }
}
