using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    private CharacterModel charModel;
    private CharacterInteraction charInteraction;
    private CharacterMovement charMovement;
    private CharacterAction charAction;
    private CharacterState charState;
    private CharacterAnimation charAnimation;

    // Use this for initialization
    void Awake()
    {
        CharModel = GetComponent<CharacterModel>();
        CharInteraction = GetComponent<CharacterInteraction>();
        CharMovement = GetComponent<CharacterMovement>();
        CharAction = GetComponent<CharacterAction>();
        CharState = GetComponent<CharacterState>();
        charAnimation = GetComponent<CharacterAnimation>();
    }

    void Start()
    {
        ScriptManager.singleton.PlayerManager = this;
    }

    public CharacterModel CharModel
    {
        get
        {
            return charModel;
        }

        set
        {
            charModel = value;
        }
    }

    public CharacterInteraction CharInteraction
    {
        get
        {
            return charInteraction;
        }

        set
        {
            charInteraction = value;
        }
    }

    public CharacterMovement CharMovement
    {
        get
        {
            return charMovement;
        }

        set
        {
            charMovement = value;
        }
    }

    public CharacterAction CharAction
    {
        get
        {
            return charAction;
        }

        set
        {
            charAction = value;
        }
    }

    public CharacterState CharState
    {
        get
        {
            return charState;
        }

        set
        {
            charState = value;
        }
    }

    public CharacterAnimation CharAnimation
    {
        get
        {
            return charAnimation;
        }

        set
        {
            charAnimation = value;
        }
    }
}
