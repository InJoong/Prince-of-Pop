using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    [SerializeField] private GameObject checkpoint;
    [SerializeField] private int playerLife = 3;
    [SerializeField] private GameObject character;
    
    // Use this for initialization
    void Start () {
        Instantiate(character, GameObject.Find("Start Point").transform.position, Quaternion.Euler(Vector2.zero));
	}
	
	// Update is called once per frame
	void Update () {

	}

    public GameObject Checkpoint
    {
        get
        {
            return checkpoint;
        }

        set
        {
            checkpoint = value;
        }
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
}
