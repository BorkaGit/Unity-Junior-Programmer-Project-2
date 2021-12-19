using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    
    public Text livesDisplay;
    public float health;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public int numOfHearts;
    public GameObject finishScore;
    private SpawnManager spawnManage;
    private void FixedUpdate()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(health))
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
                
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    void Start()
    {
        spawnManage = FindObjectOfType<SpawnManager>();
    }


    void Update()
    {
        livesDisplay.text = "Hearts: " + health.ToString();

    }
    
    public void LivesDrop()
    {
        health-=1.0f;
        if (health == 0.0f)
        {
            NoLivesLeft();
        }

    }

    public void PlayerKilled()
    {
        health = 0.0f;
        if (health == 0.0f)
        {
            NoLivesLeft();
        }
    }


    public void NoLivesLeft()
    {
        finishScore.SetActive(true);
        spawnManage.CancelSpawning();
    }
}
