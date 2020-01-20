using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaPour : MonoBehaviour
{
    public Material notActiveMaterial;
    public Material activeMaterial;
    public GameObject item;
    public string Name;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString(Name) == "Active")
        {
            this.GetComponent<MeshRenderer>().material = activeMaterial;
        }
        else
        {
            this.GetComponent<MeshRenderer>().material = notActiveMaterial;
        }

    }
    private void PerformAction()
    {
        if (item.transform.parent != null)
        {
            gameObject.SendMessage("PourTea");
            this.GetComponent<MeshRenderer>().material = activeMaterial;
            PlayerPrefs.SetString(Name, "Active");
        }
    }

}
