using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalZone : MonoBehaviour
{
    [SerializeField] public SceneInfo sceneInfo;

    [SerializeField] private String scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (PlayerPrefs.GetInt("coins", -1) != -1)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + GameObject.FindWithTag("MainCamera").GetComponent<CoinCounter>().currrentCoins);
        } else
        {
            PlayerPrefs.SetInt("coins", GameObject.FindWithTag("MainCamera").GetComponent<CoinCounter>().currrentCoins);
        }
        SceneManager.LoadScene(scene);
    }
}
