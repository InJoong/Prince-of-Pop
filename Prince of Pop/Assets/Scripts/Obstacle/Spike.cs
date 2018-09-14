using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {

    [SerializeField] private float attack = 1.0f;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            CharacterModel charModel = collision.gameObject.GetComponent<CharacterModel>();

            if (!charModel.Damaged)
            {
                Debug.Log("Spike");

                collision.gameObject.GetComponent<CharacterInteraction>().Damaged(!charModel.FacingRigth);
                charModel.Health -= attack;
                charModel.Damaged = true;
            }
        }
    }
}
