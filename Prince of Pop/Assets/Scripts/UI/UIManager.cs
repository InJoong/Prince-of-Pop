using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    //Player
    private PlayerUIAnimation playerUIAnimation;
    private PlayerUIController playerUIController;

    //Option
    private OptionUIController optionUIController;

    //Menu
    private MenuUIController menuUIController;

    // Use this for initialization
    void Awake () {
        playerUIAnimation = GetComponent<PlayerUIAnimation>();
        playerUIController = GetComponent<PlayerUIController>();
        optionUIController = GetComponent<OptionUIController>();
        menuUIController = GetComponent<MenuUIController>();
    }

    void Start()
    {
        ScriptManager.singleton.UIManager = this;
    }

    // Update is called once per frame
    void Update () {
		
	}

    public PlayerUIAnimation UIAnimation
    {
        get
        {
            return playerUIAnimation;
        }

        set
        {
            playerUIAnimation = value;
        }
    }

    public PlayerUIController PlayerUIController
    {
        get
        {
            return playerUIController;
        }

        set
        {
            playerUIController = value;
        }
    }

    public OptionUIController OptionUIController
    {
        get
        {
            return optionUIController;
        }

        set
        {
            optionUIController = value;
        }
    }

    public MenuUIController MenuUIController
    {
        get
        {
            return menuUIController;
        }

        set
        {
            menuUIController = value;
        }
    }
}
