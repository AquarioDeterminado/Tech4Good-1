using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    private TimeSpan totalTime;

    // Start is called before the first frame update
    void Start()
    {
        ShowTime();
        ShowCoins();
        
    }

    private void ShowCoins()
    {
        var totalTimeText = GameObject.Find("TotalCoins");
        Debug.Log(totalTimeText);
        Debug.Log(PlayerPrefs.GetInt("coins"));
        totalTimeText.GetComponent<TextMeshProUGUI>().text = totalTimeText.GetComponent<TextMeshProUGUI>().text + " " + PlayerPrefs.GetInt("coins").ToString();
    }

    private void ShowTime()
    {
        var startTime = DateTime.FromOADate(Double.Parse(PlayerPrefs.GetString("startTime")));
        var currentTime = DateTime.Now;

        totalTime = currentTime - startTime;

        var totalTimeText = GameObject.Find("TotalTime");

        totalTimeText.GetComponent<TextMeshProUGUI>().text =
            String.Concat(totalTimeText.GetComponent<TextMeshProUGUI>().text, " " + totalTime.Minutes + " min. " + totalTime.Seconds + " sec." );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
