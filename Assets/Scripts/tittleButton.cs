using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class tittleButton : MonoBehaviour, IPointerClickHandler
{
    private IPointerClickHandler _pointerClickHandlerImplementation;

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerPrefs.SetString("startTime", DateTime.Now.ToOADate().ToString(CultureInfo.CurrentCulture));
        SceneManager.LoadScene("SampleScene");
    }
}
