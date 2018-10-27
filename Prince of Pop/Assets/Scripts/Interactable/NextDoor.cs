using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextDoor : MonoBehaviour, Interactable {

    [SerializeField] private int scene = 2;

	public void Interact()
    {
        SceneManager.LoadScene(scene);
    }
}
