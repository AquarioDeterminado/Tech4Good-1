using UnityEngine;

public class Slide : MonoBehaviour
{
    public float slideForce = 10f; // The force applied to slide
    public float slideDuration = 0.5f; // The duration of the slide
    public KeyCode slideKey = KeyCode.S; // The key to trigger the slide

    private Rigidbody2D rb;
    private bool isSliding = false;
    private float slideTimer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("v") && !isSliding)
        {
            isSliding = true;
            slideTimer = 0f;
        }

        if (Input.GetKeyDown("a"))
        {
            transform.Rotate(0, 0, 1);
        }
        if (Input.GetKeyDown("d"))
        {
            transform.Rotate(0, 0, -1);
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
