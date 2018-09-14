using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour {

    private CharacterModel charModel;
    private CharacterInteraction charInteraction;
    private CharacterMovement charMovement;
    private CharacterAction charAction;

    // Use this for initialization
    void Awake()
    {
        CharModel = GetComponent<CharacterModel>();
        CharInteraction = GetComponent<CharacterInteraction>();
        CharMovement = GetComponent<CharacterMovement>();
        CharAction = GetComponent<CharacterAction>();
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
	
}
