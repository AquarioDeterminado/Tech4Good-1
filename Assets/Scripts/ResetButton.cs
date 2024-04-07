using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour, IPointerClickHandler
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerPrefs.DeleteKey("coins");
        SceneManager.LoadScene("Title Screen");
    }
}
