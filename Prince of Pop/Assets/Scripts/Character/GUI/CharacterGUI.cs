using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGUI : MonoBehaviour {

    private CharacterModel charModel;

    void Awake()
    {
        charModel = GetComponent<CharacterModel>();
    }

    void OnGUI()
    {
        GUILayout.Box("Player lfie: " + charModel.Health);
    }
}
