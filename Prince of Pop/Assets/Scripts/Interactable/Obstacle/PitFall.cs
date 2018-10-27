using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitFall : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            collision.gameObject.GetComponent<CharacterState>().CurrentHealth = 0;
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
