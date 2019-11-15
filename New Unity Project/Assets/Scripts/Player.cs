using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //gets input along x-axis
        float x = Input.GetAxis("Horizontal");
        //gets input along y-axis
        float y = Input.GetAxis("Vertical");

        //sets velocity * speed
        rb.velocity = new Vector3(x, 0, y) * speed;
        
    }
}
