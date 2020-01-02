using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inspiration from
// https://www.youtube.com/watch?v=hyiyjUEReYg

public class AnimatePour : MonoBehaviour
{
    public float rotationAmount = 90.0f;
    public int pourThreshold = 45;
    public Transform origin = null;
    public GameObject streamPrefab = null;

    private bool isPouring = false;
    private Stream currentStream = null;

    private Coroutine waitRoutine = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool pourCheck = CalculatePourAngle() < pourThreshold;

        if (isPouring != pourCheck)
        {
            isPouring = pourCheck;

            if (isPouring)
            {
                StartPour();
            }
            else
            {
                EndPour();
            }
        }
    }

    public void PourTea()
    {
        waitRoutine = StartCoroutine(ChangeAngle());
    }

    public void StartPour()
    {
        currentStream = CreateStream();
        currentStream.Begin();
    }

    public void EndPour()
    {
        currentStream.End();
        currentStream = null;
    }

    private Stream CreateStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin.position, Quaternion.identity, transform);
        return streamObject.GetComponent<Stream>();
    }

    private float CalculatePourAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }

    private IEnumerator ChangeAngle()
    { 
        transform.Rotate (0, rotationAmount * Time.deltaTime, 0);
        yield return new WaitForSeconds(1);
        transform.Rotate(0, -rotationAmount * Time.deltaTime, 0);

        StopCoroutine(waitRoutine);

        yield return null;
    }
}
