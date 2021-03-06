﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField] private float lifeTime = 1.0f;

    private float counter = 0;
    private float damage = 0;

    // Update is called once per frame
    void Update () {
        counter += Time.deltaTime;
        if (lifeTime <= counter)
        {
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 9 || other.gameObject.layer == 11)
        {
            Destroy(this.gameObject);
        }
    }

    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }
}
