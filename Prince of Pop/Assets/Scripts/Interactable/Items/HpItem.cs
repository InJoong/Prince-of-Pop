using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpItem : MonoBehaviour, Interactable {

    [SerializeField] private float hpUp = 1.0f;

    
    public void Interact()
    {
        CharacterState charState = ScriptManager.singleton.PlayerManager.CharState;

        if (charState.CurrentHealth != charState.MaxHealth)
        {
            charState.CurrentHealth += hpUp;

            if (charState.CurrentHealth > charState.MaxHealth)
            {
                charState.CurrentHealth -= (charState.CurrentHealth - charState.MaxHealth);
            }

            Destroy(this.gameObject);
        }
    }
}
