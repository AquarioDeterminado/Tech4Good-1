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
        
        if(maintainGround){
            RaycastHit hitFloor;
            RaycastHit hitWall;
            Physics.Raycast(transform.position,transform.up * -1,out hitFloor);
            Physics.Raycast(transform.position,transform.right,out hitWall);
            if(hitWall.transform){
                Debug.Log("Found a wall will try to rotate away from wall");
                transform.right = hitWall.normal;
                _rigidbody.velocity = hitWall.normal * _rigidbody.velocity;
            } else if(hitFloor.transform){
                transform.position = hitFloor.point ;
                _rigidbody.velocity = hitFloor.normal * _rigidbody.velocity;
                Debug.Log("Found a collider underneath!");
            }
        }
        
        if (_rigidbody.velocity.x < defaultSpeed)
        {
            RaycastHit hit;
            Physics.Raycast(transform.position, transform.forward, out hit);
            var right = transform.right;
            var foward  = new Vector2(right.x, right.z).normalized;
            _rigidbody.AddForce(foward * defaultSpeed);
        }
   
    }
}
