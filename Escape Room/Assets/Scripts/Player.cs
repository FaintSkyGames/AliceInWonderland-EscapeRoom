using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject tempParent;
    public float speed = 5;
    private Rigidbody rb;
    private Vector3 moveDirection;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //gets input along x-axis
        float x = Input.GetAxis("Horizontal");
        x *= Time.deltaTime;
        Debug.Log(x);

        //gets input along y-axis
        float y = Input.GetAxis("Vertical");
        y *= Time.deltaTime;
        Debug.Log(y);

        
        if (x != 0 && y != 0)
        {
            Debug.Log("in 1");
            audioSource.Play();
        }
        else
        {
            Debug.Log("in 2");
            audioSource.Stop();
        }
        

        moveDirection = (x * transform.right + y * transform.forward).normalized;
    }

    private void FixedUpdate()
    {
        Vector3 correctYVelocity = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = moveDirection * speed * Time.deltaTime;
        // move direction keeps setting y velocity to 0
        // to get the player to fall correctly we need to add it back
        rb.velocity += correctYVelocity;
    }

}
