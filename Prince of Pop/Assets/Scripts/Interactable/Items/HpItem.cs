using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : MonoBehaviour, Interactable {

    [SerializeField] private float hpUp = 1.0f;

    
    public void Interact()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8) {
            CharacterState charState = collision.gameObject.GetComponent<CharacterState>();

            if (charState.CurrentHealth != charState.MaxHealth) {
                charState.CurrentHealth += hpUp;

                if (charState.CurrentHealth > charState.MaxHealth)
                {
                    charState.CurrentHealth -= (charState.CurrentHealth - charState.MaxHealth);
                }

                Destroy(this.gameObject);
            }
        }
    }
}
