using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    public GameObject[ ] animalPrefabsL;
    public GameObject[ ] animalPrefabsR;
    private float spawnRangeX=13.0f;
    private float spawnPosZ=20.0f;
    private float spawnRangeZUp = 15.0f;
    private float spawnRangeZDown = 1.0f;
    private float spawnPosX = 17.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    
    void Update()
    {
      
    }

    void SpawnRandomAnimal()
    {
        //Top screen spawn
        Vector3 spawnPosT = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); 
        int animalIndex=Random.Range(0,animalPrefabs.Length);
        int animalIndexL=Random.Range(0,animalPrefabsL.Length);
        int animalIndexR=Random.Range(0,animalPrefabsR.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosT,
            animalPrefabs[animalIndex].transform.rotation);


        
        //Right screen spawn
        Vector3 spawnPosR = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZDown , spawnRangeZUp)); 
        Instantiate(animalPrefabsR[animalIndexR], spawnPosR,
            animalPrefabsR[animalIndexR].transform.rotation);
        
        //Left screen spawn
        Vector3 spawnPosL = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZDown , spawnRangeZUp)); 
        Instantiate(animalPrefabsL[animalIndexL], spawnPosL,
            animalPrefabsL[animalIndexL].transform.rotation);
        

    }

    public void CancelSpawning()
    {
        CancelInvoke();
    }
}
