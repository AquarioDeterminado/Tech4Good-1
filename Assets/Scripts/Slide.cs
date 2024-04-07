using System.Threading;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public float slideForce = 10f; // The force applied to slide
    public float slideDuration = 0.5f; // The duration of the slide
    public KeyCode slideKey = KeyCode.S; // The key to trigger the slide

    private Rigidbody2D rb;
    private bool isSliding = false;
    private float slideTimer = 0f;
    private Vector3 startingPosition;
    [SerializeField] private float rotationAngle;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown("v") && !isSliding)
        {
            isSliding = true;
            slideTimer = 0f;
        }
        if (Input.GetKeyDown("r"))
        {
            //rb.AddForce(new Vector2 (0, 100));
            // Check if the velocity is negative in the x-axis
            if (rb.velocity.x < 0)
            {
                // Invert the x-axis velocity
                rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
            }

            // Check if the velocity is negative in the y-axis
            if (rb.velocity.y < 0)
            {
                // Invert the y-axis velocity
                rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
            }
            transform.position = startingPosition;
        }
        if (Input.GetKey("a")) 
        {
            transform.Rotate(new Vector3(0, 0, rotationAngle * (-1)));
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3 (0,0, rotationAngle));
        }
    }

    void FixedUpdate()
    {
        if (isSliding)
        {
            slideTimer += Time.fixedDeltaTime;
            if (slideTimer < slideDuration)
            {
                // Apply a force to slide in the desired direction
                rb.AddForce(Vector2.down * slideForce, ForceMode2D.Force);
            }
            else
            {
                isSliding = false;
            }
        }
    }
}
