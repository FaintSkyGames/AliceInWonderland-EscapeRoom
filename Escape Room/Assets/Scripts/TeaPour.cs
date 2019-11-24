using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaPour : MonoBehaviour
{
    public Material originalMaterial;
    public Material newMaterial;
    public GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (item.transform.parent != null)
        {
            this.GetComponent<MeshRenderer>().material = newMaterial;
        }
    }
}
