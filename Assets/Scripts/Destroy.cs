using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private float Bound=25.0f;
    private LivesManager lm;
    
    void Start()
    {
        lm = FindObjectOfType<LivesManager>();
    }

    
     void Update()
    {
        if (transform.position.z > Bound ) 
        {
            Destroy(gameObject);
        }else if(transform.position.z < -Bound  || transform.position.x > Bound || transform.position.x < -Bound)

        {
            lm.LivesDrop();
            Debug.Log("Game Over!");
            Destroy(gameObject); 
            
            
        }
    }
}
