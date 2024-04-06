using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameEnv : MonoBehaviour
{

    private GameObject _player;

    private GameObject _camera;
        // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _camera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    
    void StartGame()
    {
        PrepareCamera();
        EnablePlayer();
    }

    void EnablePlayer()
    {
        _player.SetActive(true);
    }

    void PrepareCamera()
    {
        var camAnim = _camera.GetComponent<Animator>();
    }
}
