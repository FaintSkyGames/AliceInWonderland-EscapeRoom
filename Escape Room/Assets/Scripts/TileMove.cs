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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        if (Vector3.Distance(this.transform.position, slot.position) == 1)
        {
            xtemp = this.transform.position.x;
            ytemp = this.transform.position.y;

            // 6 should be replaced with whatever the z value of the group holding the tiles is
            this.transform.position = new Vector3(slot.position.x, slot.position.y, 6f);
            slot.position = new Vector3(xtemp, ytemp, 6f);
        }
    }
}
