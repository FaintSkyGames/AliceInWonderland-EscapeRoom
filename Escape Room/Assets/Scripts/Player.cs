using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject tempParent;
    public float speed = 5;
    private Rigidbody rb;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //gets input along x-axis
        float x = Input.GetAxis("Horizontal");
        x *= Time.deltaTime;
        //gets input along y-axis
        float y = Input.GetAxis("Vertical");
        y *= Time.deltaTime;

        moveDirection = (x * transform.right + y * transform.forward).normalized;

        Interact();
    }

    private void FixedUpdate()
    {
        Vector3 correctYVelocity = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = moveDirection * speed * Time.deltaTime;
        // move direction keeps setting y velocity to 0
        // to get the player to fall correctly we need to add it back
        rb.velocity += correctYVelocity;
    }

    private void Interact()
    {
        if (Input.GetKey("e"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.collider.tag == "PickUp")
                {
                    Debug.Log("Here is an object!");
                }
            }
        }

        /*
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hit, 100))
        {
            if (hit.collider.tag == "PickUp")
            {
                Debug.Log("Here is an object!");
            }
            else
            {
                Debug.Log("hit");
            }
            
        }
        else
        {
            Debug.Log("No hit.");
        }
        */
    }
}
