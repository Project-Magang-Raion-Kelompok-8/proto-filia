using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_status : MonoBehaviour {

    public int maxHealth = 100;
    int currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;	
	}
	
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy die!");
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
