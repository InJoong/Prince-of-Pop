using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField] private float lifeTime = 1.0f;

    private float counter = 0;

    // Update is called once per frame
    void Update () {
        counter += Time.deltaTime;
        Debug.Log(counter);
        if (lifeTime <= counter)
        {
            DestroyObject(this.gameObject);
        }
	}
}
