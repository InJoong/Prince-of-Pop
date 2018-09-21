using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField] private float lifeTime = 1.0f;

    private float counter = 0;

    // Update is called once per frame
    void Update () {
        counter += Time.deltaTime;
        if (lifeTime <= counter)
        {
            DestroyObject(this.gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 9 || other.gameObject.layer == 11)
        {
            Destroy(this.gameObject);
        }
    }
}
