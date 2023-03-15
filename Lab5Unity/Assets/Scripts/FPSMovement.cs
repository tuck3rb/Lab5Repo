using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FPSMovement : MonoBehaviour
{
    public GameObject body;
    private Rigidbody rigidbody;
    private Animator animator;
    private bool grounded = true;
    private float horizontal;
    private float vertical;
    private float moveLimiter = 0.7f;
    public float runSpeed = 5f;
    public float boundaryPercent;
    public float easing;
    private float lBound;
    private float rBound;
    private float uBound;
    private float dBound;


    void Start () {
        animator = body.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        lBound = boundaryPercent * Camera.main.pixelWidth;
        rBound = Camera.main.pixelWidth - lBound;
        dBound = boundaryPercent * Camera.main.pixelHeight;
        uBound = Camera.main.pixelHeight - dBound;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // when you want to dance
        if (Input.GetKeyDown(KeyCode.N) && grounded)
        {
            animator.SetTrigger("breakdance");
        }

        if (Input.GetKeyDown(KeyCode.M) && grounded)
        {
            animator.SetTrigger("cancan");
        }

        if (Input.GetKeyDown(KeyCode.J) && grounded)
        {
            animator.SetTrigger("standard");
        }

        if (Input.GetKeyDown(KeyCode.K) && grounded)
        {
            animator.SetTrigger("hiphop");
        }

        if (Input.GetKeyDown(KeyCode.L) && grounded)
        {
            animator.SetTrigger("twerk");
        }

        if (Input.GetKeyDown(KeyCode.U) && grounded)
        {
            animator.SetTrigger("gangnam");
        }

        if (Input.GetKeyDown(KeyCode.I) && grounded)
        {
            animator.SetTrigger("flair");
        }

    }

    void FixedUpdate() {
        if (horizontal != 0 && vertical != 0) {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
        Vector3 v = new Vector3(horizontal * runSpeed, 0, vertical * runSpeed);
        animator.SetFloat("speed", v.sqrMagnitude);
        print(v);
        if (v != Vector3.zero)
        {
            gameObject.transform.forward = v;
        }
        rigidbody.velocity = v + new Vector3(0, rigidbody.velocity.y, 0);
        if (body) {
            Vector3 spriteLoc = Camera.main.WorldToScreenPoint(body.transform.position);
            Vector3 pos = transform.position;

            if (spriteLoc.x < lBound) {
                pos.x -= lBound - spriteLoc.x;
            } else if (spriteLoc.x > rBound) {
                pos.x += spriteLoc.x - rBound;
            }

            if (spriteLoc.z < dBound) {
                pos.z -= dBound - spriteLoc.z;
            } else if (spriteLoc.z > uBound) {
                pos.y += spriteLoc.z - uBound;
            }

            pos = Vector3.Lerp(transform.position, pos, easing);

            transform.position = pos;

    }}

    /// <summary>
    /// Check for collision back to the ground, and re-enable the NavMeshAgent
    /// </summary>
    private void OnCollisionEnter(Collision collision)
    {
        print("Hit Something!");
        if (collision.collider != null && collision.collider.tag == "Ground")
        {
            print("It is the ground!");
            if (!grounded)
            {
                grounded = true;
            }
        }
    }
}