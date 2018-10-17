using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : MonoBehaviour {

    private PlayerManager playerManager;

    private float currentHealth;
    private float maxHealth;
    private float damageTime = 0;

    // Use this for initialization
    void Awake () {
        playerManager = GetComponent<PlayerManager>();
        CurrentHealth = playerManager.CharModel.Health;
        MaxHealth = playerManager.CharModel.Health;
    }
	
	// Update is called once per frame
	void Update () {
        if (playerManager.CharModel.Damaged)
        {
            damageTime += Time.deltaTime;

            if (damageTime >= 0.6f)
            {
                playerManager.CharModel.Damaged = false;
                damageTime = 0;
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
}
