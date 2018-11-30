using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : MonoBehaviour {

    private PlayerManager playerManager;

    private float currentHealth;
    private float maxHealth;
    private bool damaged;
    private bool invinsible;

    [SerializeField] private float damageTime = 0.6f;
    [SerializeField] private float invinsibleTime = 0.6f;
    
    private float deathTimer = 0;
    private Rigidbody2D rb2D;

    // Use this for initialization
    void Start () {
        playerManager = GetComponent<PlayerManager>();
        CurrentHealth = playerManager.CharModel.Health;
        MaxHealth = playerManager.CharModel.Health;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;

            if (playerManager.CharMovement.Grounded) {

                deathTimer += Time.deltaTime;

                if (deathTimer >= 1.5f) {
                    Physics2D.IgnoreLayerCollision(8, 9, false);
                    ScriptManager.singleton.SceneController.Return();
                }
            }
        }
    }

    public void DecreaseHealth(float value)
    {
        CurrentHealth -= value;
        Damaged = true;
        
        float nockBack = transform.localScale.x * 300;
        rb2D.velocity = Vector2.zero;
        rb2D.AddForce(new Vector2(-nockBack, 100));

        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        Physics2D.IgnoreLayerCollision(8, 9, true);

        Invoke("Undamageable", damageTime);
    }

    public void Undamageable()
    {
        Damaged = false;
        Invinsible = true;

        rb2D.velocity = Vector2.zero;
        rb2D.AddForce(Vector2.zero);
        this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        Invoke("Damageable", invinsibleTime);
    }

    public void Damageable()
    {
        Invinsible = false;

        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        Physics2D.IgnoreLayerCollision(8, 9, false);
    }

    public float CurrentHealth
    {
        get
        {
            return currentHealth;
        }

        set
        {
            currentHealth = value;
        }
    }

    public float MaxHealth
    {
        get
        {
            return maxHealth;
        }

        set
        {
            maxHealth = value;
        }
    }

    public bool Damaged
    {
        get
        {
            return damaged;
        }

        set
        {
            damaged = value;
        }
    }

    public bool Invinsible
    {
        get
        {
            return invinsible;
        }

        set
        {
            invinsible = value;
        }
    }
}
