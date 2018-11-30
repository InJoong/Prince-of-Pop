using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Russle_Bullet : MonoBehaviour {

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 9 || collision.gameObject.layer == 11)
        {
            Destroy(this.gameObject);
        }
    }
}
