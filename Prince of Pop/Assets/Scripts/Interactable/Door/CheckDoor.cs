using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckDoor : MonoBehaviour, Interactable {

    public void Interact()
    {
        int level = ScriptManager.singleton.SceneController.NextLevel;
        SceneManager.LoadScene(level);
    }
}
