using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menu = null;
    private bool isShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }
    }

    public void StartGame()
    {
        // Loads the Game scene
        isShowing = false;
        SceneManager.LoadScene("MainRoom");
    }

    public void BackToMainMenu()
    {
        // Loads the Main Menu scene
        isShowing = false;
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        // Ends the program
        Application.Quit();
    }






}
