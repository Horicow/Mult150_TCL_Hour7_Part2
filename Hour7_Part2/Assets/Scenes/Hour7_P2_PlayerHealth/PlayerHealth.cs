using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	public float health = 1004f;
	public float poisonDamage = 125.5f;	

        void Start()
    {
        Debug.Log("Player health: " + health);
		ApplyPoisonDamage();

    }

       void ApplyPoisonDamage()
    {
        while (health > 0)
	{
		health -= poisonDamage;
		
		if (health <= 0)
		{
			health =0;
			Debug.Log("Player Has Been Unalived!");
		}
		else
		{
			Debug.Log("Player Took Poison Damage. Current health: " + health);
		}
	}		
    }
}