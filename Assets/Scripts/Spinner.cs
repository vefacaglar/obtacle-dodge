using UnityEngine;

public class Spinner : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
