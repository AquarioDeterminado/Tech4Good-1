using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    private TimeSpan totalTime;
    
    // Start is called before the first frame update
    void Start()
    {
        var startTime = DataSaver.loadData<DateTime>("startTime");
        var currentTime = DateTime.Now;

        totalTime = currentTime - startTime;

        var totalTimeText = GameObject.Find("TotalTime");

        totalTimeText.GetComponent<Text>().text = String.Concat(totalTimeText.GetComponent<Text>().text, totalTimeText.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
