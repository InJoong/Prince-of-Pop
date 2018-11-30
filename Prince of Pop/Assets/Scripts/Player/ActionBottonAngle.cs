using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBottonAngle : MonoBehaviour {

    Vector2 fixedRotation;

    void Awake()
    {
    }

    // Update is called once per frame
    void LateUpdate () {
        if (transform.parent.localScale.x < 0 && transform.localScale.x > 0)
        {
            Vector3 imageScale = this.transform.localScale;
            imageScale.x *= -1;
            transform.localScale = imageScale;
        }
        else if(transform.parent.localScale.x > 0 && transform.localScale.x < 0) 
        {
            Vector3 imageScale = this.transform.localScale;
            imageScale.x *= -1;
            transform.localScale = imageScale;
        }
    }
}
