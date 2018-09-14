using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : MonoBehaviour {

    [SerializeField] private float hpUp = 3.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8) {
            CharacterModel charModel = collision.gameObject.GetComponent<CharacterModel>();

            if (charModel.Health != 10) {
                charModel.Health += hpUp;

                if (charModel.Health > 10)
                {
                    charModel.Health -= (charModel.Health - 10);
                }

                Destroy(this.gameObject);
            }
        }
    }
}
