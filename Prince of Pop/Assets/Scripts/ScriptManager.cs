using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptManager : MonoBehaviour {

    public static ScriptManager singleton;

    private PlayerManager playerManager;
    private InputManager inputManager;
    private UIManager uIManager;
    private SceneController sceneController;

    // Use this for initialization
    void Awake()
    {
        if (singleton == null) { singleton = this; }
        else if (singleton != this) { Destroy(this); }
    }

    public PlayerManager PlayerManager
    {
        get
        {
            return playerManager;
        }

        set
        {
            playerManager = value;
        }
    }

    public InputManager InputManager
    {
        get
        {
            return inputManager;
        }

        set
        {
            inputManager = value;
        }
    }

    public UIManager UIManager
    {
        get
        {
            return uIManager;
        }

        set
        {
            uIManager = value;
        }
    }

    public SceneController SceneController
    {
        get
        {
            return sceneController;
        }

        set
        {
            sceneController = value;
        }
    }
}
