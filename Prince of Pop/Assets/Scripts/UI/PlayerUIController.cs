using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUIController : MonoBehaviour {

    [SerializeField] private Image selectedWeapon;
    [SerializeField] private GameObject menuOptions;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeSelectedWeaponImage(Sprite image)
    {
        selectedWeapon.sprite = image;
    }

    public void MenuOptionVisible()
    {
        menuOptions.SetActive(true);
    }

    public void MenuOptionInvisible()
    {
        menuOptions.SetActive(false);
    }
}
