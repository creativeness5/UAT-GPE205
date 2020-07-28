using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{
    public TankData data;
    // For when to implement health.

   
    void OnCollisionEnter(Collision colli)
    {
        // If the bullet collides with anything tagged enemy, it will destroy the enemy and itself.
        if(colli.gameObject.tag == "Enemy")
        {
            Debug.Log("You hit the enemy.");
            Destroy(colli.gameObject);
            Destroy(gameObject);
        }
    }
}
