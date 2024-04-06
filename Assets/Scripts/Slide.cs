using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{

    [SerializeField] private float defaultSpeed = 0.5f;
    private bool maintainGround = true;
    private Rigidbody2D _rigidbody;



    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (maintainGround)
        {
            RaycastHit hitFloor;
            RaycastHit hitWall;
            Physics.Raycast(transform.position, transform.up * -1, out hitFloor);
            Physics.Raycast(transform.position, transform.right, out hitWall);
            if (hitWall.transform)
            {
                Debug.Log("Found a wall will try to rotate away from wall");
                transform.forward = hitWall.normal * _rigidbody.velocity.magnitude;
            }
            else if (hitFloor.transform)
            {
                transform.position = hitFloor.point * _rigidbody.velocity.magnitude;
                Debug.Log("Found a collider underneath!");
            }
        }

        /*if (_rigidbody.velocity.x < defaultSpeed)
        {
            var right = transform.right;
            var foward = new Vector2(right.x, right.z).normalized;
            Vector2 velocity = (new Vector2(foward.x, foward.y 1.5f)) * defaultSpeed;
            _rigidbody.velocity = velocity;
        }
        */
    }
}