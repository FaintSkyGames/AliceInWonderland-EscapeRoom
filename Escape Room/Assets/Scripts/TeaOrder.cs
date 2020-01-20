using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaOrder : MonoBehaviour
{
    public GameObject cup1;
    public GameObject cup2;
    public GameObject cup3;
    public GameObject cup4;
    public GameObject cup5;
    public GameObject cup6;

    public GameObject vial;

    private AudioSource audioSource;
    public AudioClip drain;
    public AudioClip pour;

    private bool allCupsActive = false;
    private int currentItteration = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (allCupsActive == false)
        {
            CheckCups();

            if (allCupsActive == false)
            {
                if (CheckOrder() != currentItteration)
                {
                    DeactivateAll();
                    audioSource.Stop();
                    audioSource.clip = drain;
                    audioSource.Play();
                }
            }
        }
        
    }

    private void CheckCups()
    {
        currentItteration = 0;

        if (PlayerPrefs.GetString("Cup1") == "Active")
        {
            currentItteration += 1;
            if (PlayerPrefs.GetString("Cup2") == "Active")
            {
                currentItteration += 1;
                if (PlayerPrefs.GetString("Cup3") == "Active")
                {
                    currentItteration += 1;
                    if (PlayerPrefs.GetString("Cup4") == "Active")
                    {
                        currentItteration += 1;
                        if (PlayerPrefs.GetString("Cup5") == "Active")
                        {
                            currentItteration += 1;
                            if (PlayerPrefs.GetString("Cup6") == "Active")
                            {
                                currentItteration += 1;
                                allCupsActive = true;

                                vial.SetActive(true);
                            }
                        }
                    }
                }
            }
        }
    }

    private int CheckOrder()
    {
        int activeCups = 0;

        if (PlayerPrefs.GetString("Cup1") == "Active")
            activeCups += 1;
        if (PlayerPrefs.GetString("Cup2") == "Active")
            activeCups += 1;
        if (PlayerPrefs.GetString("Cup3") == "Active")
            activeCups += 1;
        if (PlayerPrefs.GetString("Cup4") == "Active")
            activeCups += 1;
        if (PlayerPrefs.GetString("Cup5") == "Active")
            activeCups += 1;
        if (PlayerPrefs.GetString("Cup6") == "Active")
            activeCups += 1;

        return activeCups;
    }

    private void DeactivateAll()
    {
        PlayerPrefs.SetString("Cup1", "Not active");
        PlayerPrefs.SetString("Cup2", "Not active");
        PlayerPrefs.SetString("Cup3", "Not active");
        PlayerPrefs.SetString("Cup4", "Not active");
        PlayerPrefs.SetString("Cup5", "Not active");
        PlayerPrefs.SetString("Cup6", "Not active");
    }

    public void PlayPourSound()
    {
        audioSource.Stop();
        audioSource.clip = pour;
        audioSource.Play();

    }
}
