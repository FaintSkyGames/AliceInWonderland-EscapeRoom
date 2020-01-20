using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaPour : MonoBehaviour
{
    public GameObject liquid;
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
            liquid.SetActive(true);
        }
        else
        {
            liquid.SetActive(false);
        }

    }
    private void OnMouseDown()
    {
        if (item.transform.parent != null)
        {
            //gameObject.SendMessage("PourTea");
            gameObject.SendMessageUpwards("PlayPourSound");
            liquid.SetActive(true);
            PlayerPrefs.SetString(Name, "Active");
        }
    }

}
