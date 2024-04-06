using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private GameObject _warmBox;
    private Vector3 _playerPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        _warmBox = GameObject.FindWithTag("Player");
        _playerPosition = _warmBox.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = _warmBox.transform.position;
        if (newPosition != _playerPosition)
        {
            this.transform.Translate(new Vector3(newPosition.x - _playerPosition.x,0, 0));
            _playerPosition = newPosition;
        }
    }
}
