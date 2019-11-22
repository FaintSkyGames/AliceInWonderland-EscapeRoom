using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePuzzle : MonoBehaviour
{
    public Transform tile1, tile2, tile3, tile4, tile5, tile6, tile7, tile8, tile9;
    public GameObject slot;

    private Vector3 position1 = new Vector3(1, 9, 0);
    private Vector3 position2 = new Vector3(2, 9, 0);
    private Vector3 position3 = new Vector3(3, 9, 0);
    private Vector3 position4 = new Vector3(1, 8, 0);
    private Vector3 position5 = new Vector3(2, 8, 0);
    private Vector3 position6 = new Vector3(3, 8, 0);
    private Vector3 position7 = new Vector3(1, 7, 0);
    private Vector3 position8 = new Vector3(2, 7, 0);
    private Vector3 position9 = new Vector3(3, 7, 0);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool CheckTile()
    {
        if (tile1.position == position1)
        {

        }
        return true;
    }
}
