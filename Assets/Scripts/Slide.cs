using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{

    [SerializeField] private float defaultSpeed = 0.5f;
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody.velocity.x < defaultSpeed)
        {
            var right = transform.right;
            var foward  = new Vector2(right.x, right.z).normalized;
            Vector2 velocity =  (new Vector2(foward.x, foward.y * 1.5f)) * defaultSpeed;
            _rigidbody.velocity = velocity;
        }
    }
}
