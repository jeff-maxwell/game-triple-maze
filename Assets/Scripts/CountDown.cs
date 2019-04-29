using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public int timeLeft = 120;
    public Text timeLeftText;

    void Start()
    {
        // Call the DecreaseTime method to start the countdown
        StartCoroutine("IncreaseTime");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Display the current time left
        timeLeftText.text = $"Time Left: {FormatTime()}";
    }

    private string FormatTime()
    {
        // Format the clock time
        string minutes = (timeLeft / 60).ToString();
        string seconds = (timeLeft % 60).ToString();
        seconds = seconds.PadLeft(2, '0');

        return $"{minutes}:{seconds}";
    }

    // Decreases the time as long as it is > 0
    IEnumerator IncreaseTime()
    {
        while (true)
        {
            if (timeLeft >= 0)
            {
                yield return new WaitForSeconds(1);
                timeLeft--;
            }
        }
    }
}
