using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeAI : MonoBehaviour
{
    GameObject start;
    public static int ballCount = 3;
    public GameObject ball;
    public GameObject welcomePanel;
    public Text timerText;
    public Text endTimerText;
    private int currentTimeinSeconds = 0;
    private bool initialLoad = true;

    void Start()
    {
        ShowWelcome(true);
    }

    public void Play()
    {
        ShowWelcome(false);
        MazeAI.ballCount = 3;

        CreateBall("1");
        CreateBall("2");
        CreateBall("3");

        currentTimeinSeconds = 0;

        StartTimer();
        initialLoad = false;
    }

    private void CreateBall(string number)
    {
        start = GameObject.FindGameObjectWithTag("Start" + number);
        ball.tag = "Ball" + number;
        Instantiate(ball, start.transform.position, Quaternion.identity);
    }

    public void Quit()
    {
        print("Quit");
        Application.Quit();
    }

    public void StartTimer()
    {
        StartCoroutine("IncreaseTime");
        Time.timeScale = 1;
    }

    public void StopTimer()
    {
        StopCoroutine("IncreaseTime");
    }

    IEnumerator IncreaseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            currentTimeinSeconds++;
        }
    }

    public void ShowWelcome(bool show)
    {
        welcomePanel.SetActive(show);

        var playButton = GameObject.FindGameObjectWithTag("PlayButton");

        if (show == true)
        {
            StopTimer();
            if (initialLoad)
            {
                endTimerText.text = "";
                playButton.GetComponentInChildren<Text>().text = "Play";
            }
            else
            {
                endTimerText.text = $"Time: {FormatTime()}";
                playButton.GetComponentInChildren<Text>().text = "Play Again";
            }
        }
    }

    private string FormatTime()
    {
        // Format the clock time
        string minutes = (currentTimeinSeconds / 60).ToString();
        string seconds = (currentTimeinSeconds % 60).ToString();
        seconds = seconds.PadLeft(2, '0');

        return $"{minutes}:{seconds}";
    }

    void Update()
    {
        timerText.text = $"Time: {FormatTime()}";
    }
}
