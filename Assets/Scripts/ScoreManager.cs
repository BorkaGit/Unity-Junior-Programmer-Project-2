using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
  public float score;
  public Text scoreDisplay;

  private void FixedUpdate()
  {
    
    scoreDisplay.text = "Score: " + ((Mathf.FloorToInt(score))).ToString();
  }

  public void Feed()
  {
    score+=1.0f;

  }
}
