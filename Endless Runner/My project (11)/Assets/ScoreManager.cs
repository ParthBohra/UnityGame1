using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float number;
    public float numberIncrement;
    public Text numberText;

    private void Start()
    {
        StartCoroutine(IncrementNumber());
    }

    IEnumerator IncrementNumber()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); // Increment the number every second
            number += numberIncrement;
            numberText.text = number.ToString(); // Update the UI text with the new number
        }
    }
}
