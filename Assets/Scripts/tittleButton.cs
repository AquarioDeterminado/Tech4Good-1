using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class tittleButton : MonoBehaviour, IPointerClickHandler
{
    private IPointerClickHandler _pointerClickHandlerImplementation;

    public void OnPointerClick(PointerEventData eventData)
    {
        DataSaver.saveData(DateTime.Now, "startTime");
        SceneManager.LoadScene("SampleScene");
    }
}
