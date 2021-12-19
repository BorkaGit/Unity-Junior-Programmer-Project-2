using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsHealth : MonoBehaviour
{
    public int maxHealth=10;
    public int currentHealth;
    
    //public HealthBar healthbar;
     
    private ScoreManager sm;
    void Start()
    {   
        //currentHealth = maxHealth;
        //healthbar.SetMaxHealth(maxHealth);
        //sm = FindObjectOfType<ScoreManager>();
    }


    void Update()
    {

    }

    void TakeDamage(int damage)
    {
        //currentHealth -= damage;
        //healthbar.SetHealth(currentHealth);
    }
    private void OnTriggerEnter(Collider other)
    {
        //TakeDamage(2);
       
       // if (currentHealth == 0)
        {
           // sm.Feed();
            //Destroy(gameObject);
            //Destroy(other.gameObject);
        }

    }
    
}
