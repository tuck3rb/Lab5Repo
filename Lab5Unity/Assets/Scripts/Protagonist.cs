using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonist : MonoBehaviour

{

    public Rigidbody body;
    public float horizontal;
    public float vertical;

    private float moveLimiter = 0.7f;

    private float c = 0;
    public float runSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = (-1) * Input.GetAxisRaw("Horizontal");
        vertical = (-1) * Input.GetAxisRaw("Vertical");
        if ((vertical == 0) && (horizontal == 0)) {
            c = 0;
        }
        if ((vertical != 0) && (c==0)){
            body.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
            c++;
        }

        if ((horizontal < 0) && (c==0)){
            body.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
            c++;
        }

        if ((horizontal > 0) && (c==0)){
            body.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            c++;
        }

        transform.position = transform.position + new Vector3(horizontal * runSpeed, 0, vertical * runSpeed);
    }
}