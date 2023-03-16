using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonist : MonoBehaviour

{

    public Rigidbody body;
    public float horizontal;
    public float vertical;

    private float moveLimiter = 0.7f;

    public float runSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (vertical < 0) {
            body.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        }

        if (horizontal < 0) {
            body.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }

        if (horizontal > 0) {
            body.transform.Rotate(0.0f, 270.0f, 0.0f, Space.Self);
        }

        transform.position = transform.position + new Vector3(horizontal * runSpeed, 0, vertical * runSpeed);
    }
}