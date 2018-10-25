using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : MonoBehaviour {

    private PlayerManager playerManager;

    private float currentHealth;
    private float maxHealth;
    private bool damaged;
    private bool undamagable;

    [SerializeField] private float damageTime = 0.6f;

    private float count = 0;

    // Use this for initialization
    void Start () {
        playerManager = GetComponent<PlayerManager>();
        CurrentHealth = playerManager.CharModel.Health;
        MaxHealth = playerManager.CharModel.Health;
    }
	
	// Update is called once per frame
	void Update () {
        if (Damaged)
        {
            count += Time.deltaTime;

            if (count >= damageTime)
            {
                Damaged = false;
                count = 0;
                Undamageable();
            }
        }

        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
    }

    public void DecreaseHealth(float value)
    {
        CurrentHealth -= value;
    }

    public void KnockBack()
    {
        Damaged = true;
        float nockBack = transform.localScale.x * 500;
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-nockBack, 100));
    }

    public void Undamageable()
    {

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

    public bool Undamagable
    {
        get
        {
            return undamagable;
        }

        set
        {
            undamagable = value;
        }
    }
}
