using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    
    [SerializeField] private int playerLife = 3;
    [SerializeField] private int nextLevel = 1;

    private string sceneName;
    [SerializeField] private string startName = "Start Point";
    
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

            
            if (SceneManager.GetActiveScene().name == "Graveyard")
            {
                GameObject.Find("Character").transform.position = GameObject.Find("Start Point").transform.position;
            }
            else
            {
                GameObject.Find("Character").transform.position = GameObject.Find(startName).transform.position;
            }
        }

        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            Destroy(GameObject.Find("Game Master"));
        }


        Debug.Log("Hola");
	}

    public void Return()
    {
        SceneManager.LoadScene(4);
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
