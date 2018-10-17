using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    private UIAnimation uIAnimation;

    // Use this for initialization
    void Awake () {
        uIAnimation = GetComponent<UIAnimation>();
    }

    void Start()
    {
        ScriptManager.singleton.UIManager = this;
    }

    // Update is called once per frame
    void Update () {
		
	}


    public UIAnimation UIAnimation
    {
        get
        {
            return uIAnimation;
        }

        set
        {
            uIAnimation = value;
        }
    }
}
