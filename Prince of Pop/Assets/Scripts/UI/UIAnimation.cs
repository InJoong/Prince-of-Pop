using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimation : MonoBehaviour {

    [SerializeField] private Animator healthBar;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        healthBar.SetFloat("Health", ScriptManager.singleton.PlayerManager.CharState.CurrentHealth);
    }
}
