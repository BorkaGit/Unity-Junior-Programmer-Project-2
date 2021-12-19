using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float horizontalInput;
    public float verticalInput;
    public float xRange = 25;
    public float zTopRange = 17;
    public float zDownRange = -2;
    public GameObject projectilePrefab;
    void Start()
    {

    }


    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.z > zTopRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zTopRange);
        }
        else if (transform.position.z < zDownRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,  zDownRange);
        }
    
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 vec = new  Vector3(0, 0, 2);
           
            Instantiate(projectilePrefab, transform.position+ vec, projectilePrefab.transform.rotation);
        }
    }
}