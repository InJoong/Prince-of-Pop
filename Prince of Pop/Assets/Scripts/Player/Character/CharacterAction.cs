using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAction : MonoBehaviour {

    [SerializeField] private GameObject weapon;

    public void Shoot()
    {
        if (this.Weapon != null) {
            Weapon.GetComponent<WeaponInteractable>().Fire();
        }
    }

    public GameObject Weapon
    {
        get
        {
            return weapon;
        }

        set
        {
            weapon = value;
        }
    }
}
