using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    private TimeSpan totalTime;

    // Start is called before the first frame update
    void Start()
    {
        ShowTime();
        
        
    }

    private void ShowCoins()
    {
        var totalTimeText = GameObject.Find("TotalCoins");

        totalTimeText.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("coins").ToString();
    }

    private void ShowTime()
    {
        var startTime = DateTime.FromOADate(Double.Parse(PlayerPrefs.GetString("startTime")));
        var currentTime = DateTime.Now;

        totalTime = currentTime - startTime;

        var totalTimeText = GameObject.Find("TotalTime");

        totalTimeText.GetComponent<TextMeshProUGUI>().text =
            String.Concat(totalTimeText.GetComponent<TextMeshProUGUI>().text, " " + totalTime.TotalMinutes + " min");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
