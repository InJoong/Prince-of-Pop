using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakablePlat : MonoBehaviour {

    public int TouchCounter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.name=="Character"){
            TouchCounter--;
        }
        if(TouchCounter==0){
            Destroy(gameObject);
        }
    }
    
    
    
}
