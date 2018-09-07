using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    private CharacterModel charModel;

    private void Start()
    {
        charModel = GetComponent<CharacterModel>();
    }

    public void Move(float x)
    {
        gameObject.transform.Translate(x, 0, 0);
    }

    public void Jump()
    {

    }
}
