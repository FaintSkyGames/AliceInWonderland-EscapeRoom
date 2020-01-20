using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMove : MonoBehaviour
{

    public Transform slot;
    private float xtemp;
    private float ytemp;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }

    }
    */

    private void OnMouseDown()
    {
        if (Vector3.Distance(this.transform.position, slot.position) == 1)
        {
            xtemp = this.transform.position.x;
            ytemp = this.transform.position.y;

            // 6 should be replaced with whatever the z value of the group holding the tiles is
            this.transform.position = new Vector3(slot.position.x, slot.position.y, 0f);
            slot.position = new Vector3(xtemp, ytemp, 0f);
        }
    }
}
