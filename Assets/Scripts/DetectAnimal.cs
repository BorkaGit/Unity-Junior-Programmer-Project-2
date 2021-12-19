using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAnimal : MonoBehaviour
{
    private LivesManager lma;
    void Start()
    {
        lma = FindObjectOfType<LivesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        lma.PlayerKilled();
        Debug.Log("Game Over!");
        
        
    }
}