using UnityEngine;

public class LimitRotation : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    float rotationSpeed = 45;
    Vector3 currentEulerAngles;
    Quaternion currentRotation;
    float z;

    void Update()
    {
        if (transform.rotation.z >= 90)
        {
            rb.MoveRotation(45);
        }
        if (transform.rotation.z  <= -90)
        {
            rb.MoveRotation(-45);
        }
    }
}
