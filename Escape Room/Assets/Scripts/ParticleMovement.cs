using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{
    // Variables which can be changed manually in unity.
    public float velocityMax = 0.02f;
    public float zMax;
    public float xMax;
    public float zMin;
    public float xMin;

    // Variables that hold the transformation for each axis.
    private float z;
    private float x;


    // Use this for initialization
    void Start()
    {

        // Gives the target a random speed and a destination to move towards
        //velocityMax = Random.Range(minrange, maxrange);
        z = Random.Range(-velocityMax, velocityMax);
        x = Random.Range(-velocityMax, velocityMax);
    }

    void Update()
    {
        if (transform.localPosition.z > zMax)
            z = Random.Range(-velocityMax, 0.0f);

        if (transform.localPosition.z < zMin)
            z = Random.Range(0.0f, velocityMax);

        if (transform.localPosition.x > xMax)
            x = Random.Range(-velocityMax, 0.0f);

        if (transform.localPosition.x < xMin)
            x = Random.Range(0.0f, velocityMax);

        transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
    }
}
