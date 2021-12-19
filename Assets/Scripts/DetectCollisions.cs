using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    
    public void Start()
    {
       
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal")){
        Debug.Log("DetectCollisions");
            
            Destroy(gameObject);
            
            other.GetComponent<HealthBar>().FeedAnimal(1);
        }

        

    }
}
