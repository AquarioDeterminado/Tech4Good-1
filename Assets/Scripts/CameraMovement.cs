using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Object Prefab;
    private GameObject _warmBox;
    private Vector3 _playerPosition;
    private Quaternion _playerRotation;
    
    // Start is called before the first frame update
    void Start()
    {
        _warmBox = GameObject.FindWithTag("Player");
        _playerPosition = _warmBox.transform.position;
        _playerRotation = _warmBox.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if( _warmBox == null )
        {
            Instantiate(Prefab, _playerPosition, _playerRotation);
        } else
        {
            var newPosition = _warmBox.transform.position;
            if (newPosition != _playerPosition)
            {
                this.transform.Translate(new Vector3(newPosition.x - _playerPosition.x, 0, 0));
                _playerPosition = newPosition;
            }
        }
        
    }
}
