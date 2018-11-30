using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    
    [SerializeField] private int playerLife = 3;
    [SerializeField] private int nextLevel = 1;
    [SerializeField] private string startName = "Start Point";

    private string sceneName;
    
    // Use this for initialization
    void Start () {
        ScriptManager.singleton.SceneController = this;
        sceneName = SceneManager.GetActiveScene().name;
    }
	
	// Update is called once per frame
	void Update () {
        if (sceneName != SceneManager.GetActiveScene().name)
        {
            sceneName = SceneManager.GetActiveScene().name;

            Scene scene = SceneManager.GetActiveScene();
            GameObject[] objects = scene.GetRootGameObjects();

            for (int i=0; i<objects.Length; i++)
            {
                if (objects[i].name == "Game Master")
                {
                    Destroy(objects[i]);
                }
            }


            if (SceneManager.GetActiveScene().name == "Graveyard")
            {
                GameObject.Find("Character").transform.position = GameObject.Find("Start Point").transform.position;
            }
            else if (SceneManager.GetActiveScene().name != "Main Menu" && SceneManager.GetActiveScene().name != "Game Over" && SceneManager.GetActiveScene().name != "Intro_video" && SceneManager.GetActiveScene().name != "Outtro")
            {
                GameObject.Find("Character").transform.position = GameObject.Find(startName).transform.position;
            }
        }
	}

    public void Return()
    {
        PlayerLife--;
        if (PlayerLife >= 0) {
            SceneManager.LoadScene(4);
        }
        else
        {
            PlayerLife = 3;
            Cursor.visible = true;
            startName = "Start Point";
            SceneManager.LoadScene(5);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public int PlayerLife
    {
        get
        {
            return playerLife;
        }

        set
        {
            playerLife = value;
        }
    }

    public string StartName
    {
        get
        {
            return startName;
        }

        set
        {
            startName = value;
        }
    }

    public int NextLevel
    {
        get
        {
            return nextLevel;
        }

        set
        {
            nextLevel = value;
        }
    }
}
