using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIAnimation : MonoBehaviour {

    [SerializeField] private Animator healthBar;
    [SerializeField] private Animator lifeBar;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        healthBar.SetFloat("Health", ScriptManager.singleton.PlayerManager.CharState.CurrentHealth);
        lifeBar.SetFloat("Life", ScriptManager.singleton.SceneController.PlayerLife);
    }
}
