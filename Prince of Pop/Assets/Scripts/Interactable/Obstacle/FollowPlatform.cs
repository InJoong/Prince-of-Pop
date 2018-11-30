using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Vector3 newPos = new Vector3(0, transform.localPosition.y, 0);

            collision.transform.position = newPos;
        }
    }
}
