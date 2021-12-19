using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
     public Slider sliderFeed;
    public int amountToBeFed;
    
    private ScoreManager sm;
    

    private int currentFedAmount = 0;
    //private GameManager gameManager;

     void Start()
    {   
        sliderFeed.maxValue = amountToBeFed;
        sliderFeed.value = 0;
        sliderFeed.fillRect.gameObject.SetActive(false);
        
        sm = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
      
    }

    public void FeedAnimal(int amount)
    {   
        Debug.Log("FeedAnimal");
        currentFedAmount += amount;
        Debug.Log(currentFedAmount.ToString());
        sliderFeed.fillRect.gameObject.SetActive(true);
        sliderFeed.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {   
            Debug.Log("ABS");
            sm.Feed();
            Destroy(gameObject,0.1f);
        }
    }
    public void SetHealth(int health)
    {
        //slider.value = health;
    }
}
