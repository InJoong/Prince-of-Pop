using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrCube : MonoBehaviour {

    
    int life=2;
        
        
	// Use this for initialization
	void Start () {
		Debug.Log("I exist");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.name == "Mike")
         {
             Debug.Log("Hit");
            life--;
            if(this.life==0){
                Debug.Log("I died");
                Destroy(gameObject);
            }
         }
        
        if (col.gameObject.name == "bullet")
         {
             Debug.Log("Hit");
         }
        
        
    }
    void OnGUI(){
        GUILayout.Box("Cube lfie: "+life);
    }
    
    /*  
    void OnGUI() {
        if (GUILayout.Button("Press Me"))
            Debug.Log("Hello!");
    }
    
    void OnGUI()
    {
        GUILayout.Button("HELP");
    }
    */
    
    
    
}
