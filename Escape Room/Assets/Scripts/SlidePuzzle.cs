using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidePuzzle : MonoBehaviour
{
    public Transform tile1, tile2, tile3, tile4, tile5, tile6, tile7, tile8, tile9;
    public Transform slot;


    private Vector3 position1 = new Vector3(-1, 4, 0);
    private Vector3 position2 = new Vector3(0, 4, -0);
    private Vector3 position3 = new Vector3(1, 4, 0);
    private Vector3 position4 = new Vector3(-1, 3, 0);
    private Vector3 position5 = new Vector3(0, 3, 0);
    private Vector3 position6 = new Vector3(1, 3, 0);
    private Vector3 position7 = new Vector3(-1, 2, 0);
    private Vector3 position8 = new Vector3(0, 2, 0);
    private Vector3 position9 = new Vector3(1, 2, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is done to reduce processing.
        if (tile9.position != position9)
        {
            RunChecks();
        }
    }

    bool CheckTile(Transform tile, int name)
    {
        Debug.Log("checking " + name);
        Vector3 temp = new Vector3(0,0,0);

        switch (name)
        {
            case 1:
                temp = position1;
                break;
            case 2:
                temp = position2;
                break;
            case 3:
                temp = position3;
                break;
            case 4:
                temp = position4;
                break;
            case 5:
                temp = position5;
                break;
            case 6:
                temp = position6;
                break;
            case 7:
                temp = position7;
                break;
            case 8:
                temp = position8;
                break;
        }

        if (tile.position == temp)
        {
            return true;
        }

        return false;
    }

    void RunChecks()
    {
        if (CheckTile(tile1, 1))
        {
            if (CheckTile(tile2, 2))
            {
                if (CheckTile(tile3, 3))
                {
                    if (CheckTile(tile4, 4))
                    {
                        if (CheckTile(tile5, 5))
                        {
                            if (CheckTile(tile6, 6))
                            {
                                if (CheckTile(tile7, 7))
                                {
                                    if (CheckTile(tile8, 8))
                                    {
                                        Debug.Log("Complete");
                                        tile9.position = new Vector3(1, 2, 0);
                                        slot.position = new Vector3(-1, 2, 1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
