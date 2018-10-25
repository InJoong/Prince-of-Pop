using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

    private WeaponModel weaponModel;
    
    void Awake () {
        weaponModel = GetComponent<WeaponModel>();
	}

    public WeaponModel WeaponModel
    {
        get
        {
            return weaponModel;
        }

        set
        {
            weaponModel = value;
        }
    }
}
