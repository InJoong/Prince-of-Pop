using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_A : MonoBehaviour, Interactable, WeaponInteractable {

    private WeaponManager weaponManager;

    private float count = 0;

    // Use this for initialization
    void Start()
    {
        weaponManager = GetComponent<WeaponManager>();
        count = weaponManager.WeaponModel.ShootingCoolDown;
    }

    // Update is called once per frame
    void Update () {
        if (count <= weaponManager.WeaponModel.ShootingCoolDown)
        {
            count += Time.deltaTime;
        }
	}

    public void Interact()
    {
        foreach (Transform child in GameObject.Find("WeaponSlot").transform)
        {
            child.parent = null;
            if (child.transform.localScale.x == -1)
            {
                Vector3 imageScale = this.transform.localScale;
                imageScale.x *= -1;
                child.transform.localScale = imageScale;
            }
            child.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            child.gameObject.GetComponent<Rigidbody2D>().simulated = true;
            child.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;
        transform.parent = GameObject.Find("WeaponSlot").transform;
        transform.localPosition = Vector3.zero;
        ScriptManager.singleton.PlayerManager.CharAction.Weapon = this.gameObject;
        ScriptManager.singleton.UIManager.PlayerUIController.ChangeSelectedWeaponImage(GetComponent<SpriteRenderer>().sprite);
    }

    public void Fire()
    {
        if (count >= weaponManager.WeaponModel.ShootingCoolDown)
        {
            count = 0;

            GameObject bullet = Instantiate(weaponManager.WeaponModel.Projectile,
                ScriptManager.singleton.PlayerManager.CharModel.ProjectileOrigin.transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            bullet.GetComponent<Projectile>().Damage = weaponManager.WeaponModel.Damage;
            Vector3 imageScale = this.transform.localScale;
            bullet.transform.localScale = imageScale;

            float projectileSpeed = transform.parent.parent.localScale.x * weaponManager.WeaponModel.Speed;

            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(projectileSpeed, 0));
        }
    }

    public void Reload() { }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            Rigidbody2D rigid = GetComponent<Rigidbody2D>();

            rigid.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }
}
