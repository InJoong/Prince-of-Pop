using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAction : MonoBehaviour {

    private PlayerManager playerManager;

    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
    }

    [SerializeField] private GameObject weapon;

    public void Shoot()
    {
        if (this.Weapon != null) {
            playerManager.CharAnimation.ShootingAnimation();
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
