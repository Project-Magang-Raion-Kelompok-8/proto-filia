using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {

    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask Enemies;
    public int attackDamage=20;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Att();
        }
	}

    void Att()
    {
        //detect enemies
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, Enemies);

        //damage enemies
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("Damage" + attackDamage);
            enemy.GetComponent<Enemy_status>().TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
