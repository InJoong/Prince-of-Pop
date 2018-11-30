using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        DontDestroyOnLoad(GameObject.Find("Game Master"));
        Cursor.visible = false;
        SceneManager.LoadScene(6);
    }

    public void Continure()
    {
        SceneManager.LoadScene(4);
    }

    public void ReturnMainMenu()
    {
        Destroy(GameObject.Find("GameMaster"));
        Cursor.visible = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
