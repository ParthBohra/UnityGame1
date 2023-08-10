using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManagerr : MonoBehaviour
{
    public Text ScoreValueText;
    public float ScoreValue=0f;
    public float PointsIncreasedPerSecond=5f;

    public void Update()
    {
        ScoreValueText.text = ((int)ScoreValue).ToString();
        ScoreValue += PointsIncreasedPerSecond* Time.deltaTime;
    }
}
