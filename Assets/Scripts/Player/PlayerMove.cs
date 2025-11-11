using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speed = 7.0f;

    private float LookSensitivity = 2.0f;

    private float limitAngle = 80.0f;


    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void FixedUpdate()
    {

    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movementX = transform.right * moveX;
        Vector3 movementZ = transform.forward * moveZ;

        Vector3 movement = (movementX + movementZ).normalized * speed;
        rb.MovePosition(transform.position + movement * Time.deltaTime);
    }
}
