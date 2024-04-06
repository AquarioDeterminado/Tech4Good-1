using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDownImpulse : MonoBehaviour
{

    [SerializeField] private KeyCode keyCode = KeyCode.Space;
    [SerializeField] private float forceIntensity = 2.0f;
    private Rigidbody2D _rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            _rigidbody2D.AddForce(new Vector2(0, -1) * forceIntensity);
        }
    }
}
