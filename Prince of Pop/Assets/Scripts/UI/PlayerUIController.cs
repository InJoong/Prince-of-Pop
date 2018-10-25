using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour {

    [SerializeField] private Image selectedWeapon;

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
}
