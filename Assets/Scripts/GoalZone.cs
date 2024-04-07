using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalZone : MonoBehaviour
{
    public bool isNextScene = true;

    [SerializeField]
    public SceneInfo sceneInfo;

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

        if (PlayerPrefs.GetInt("coins") != null)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + GetComponent<CoinCounter>().currrentCoins);
        } else
        {
            PlayerPrefs.SetInt("coins", GetComponent<CoinCounter>().currrentCoins);
        }
        sceneInfo.isNextScene = isNextScene;  
        SceneManager.LoadScene(scene);
    }
}
