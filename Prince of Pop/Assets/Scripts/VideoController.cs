using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour {

    [SerializeField] private float videoTime = 26.0f;

    private float countTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        countTime += Time.deltaTime;

        if (countTime >= videoTime || Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(4);
        }
	}
}
