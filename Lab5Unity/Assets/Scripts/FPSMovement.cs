using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FPSMovement : MonoBehaviour
{
    public GameObject body;
    public Rigidbody rigidbody;
    private Animator animator;
    private bool grounded = true;
    private float horizontal;
    private float vertical;
    private float moveLimiter = 0.7f;
    public float runSpeed = 5f;
    public float boundaryPercent;
    public float easing;



    void Start () {
        animator = body.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if ((horizontal != 0f) | (vertical != 0f)) {
            animator.SetFloat("speed", 1);
        }

        if ((horizontal == 0) & (vertical == 0)) {
            animator.SetFloat("speed", 0);
        }

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

        if (Input.GetKeyDown(KeyCode.O) && grounded)
        {
            animator.SetTrigger("flair");
        }

    }


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