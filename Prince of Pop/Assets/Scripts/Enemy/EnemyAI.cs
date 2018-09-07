using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyModel))]
public class EnemyAI : MonoBehaviour {

    private EnemyModel eneModel;

    [SerializeField] private float distance = 10.0f;

    private float health = 5.0f;

	// Use this for initialization
	void Awake () {
        eneModel = GetComponent<EnemyModel>();
    }

    private void Start()
    {
        health = eneModel.Health;
    }

    void Update () {
        if (this.health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 10)
        {
            Debug.Log("Hit");
            health--;
        }
    }
}
