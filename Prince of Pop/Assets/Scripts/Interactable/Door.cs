using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, Interactable {

    [SerializeField] private int currentLevel = 1;

    public void Interact()
    {
        DontDestroyOnLoad(GameObject.Find("Game Master"));
        DontDestroyOnLoad(GameObject.Find("Character"));
        SceneManager.LoadScene(CurrentLevel);
    }

    public int CurrentLevel
    {
        get
        {
            return currentLevel;
        }

        set
        {
            currentLevel = value;
        }
    }
}
