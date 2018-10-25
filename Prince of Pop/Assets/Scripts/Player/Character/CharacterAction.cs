using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAction : MonoBehaviour {

    [SerializeField] private GameObject weapon;
    [SerializeField] private GameObject projectileOrigin;
    [SerializeField] private GameObject container;

    public void IntantiateProjectile(bool rigth)
    {
        weapon.GetComponent<WeaponInteraction>().Interaction(rigth, projectileOrigin.transform.position);
    }

    public void ChangeWeapon(GameObject weapon)
    {
        if (this.weapon != null)
        {
            container.GetComponent<WeaponContainer>().Weapon = this.weapon;
            container.GetComponent<SpriteRenderer>().sprite = this.weapon.GetComponent<SpriteRenderer>().sprite;
            Instantiate(container, transform.position, transform.rotation);
        }
        this.weapon = weapon;
    }
}
