using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameEnv : MonoBehaviour
{

    private GameObject _player;
    private Time startTime;

    private GameObject _camera;
        // Start is called before the first frame update
    void Start()
    {
        startTime = new Time();
        _camera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    
    void StartGame()
    {
        PrepareCamera();
    }
    

    void PrepareCamera()
    {
        var camAnim = _camera.GetComponent<Animator>();
    }

    Time getStartTime()
    {
        return startTime;
    }
        
}
