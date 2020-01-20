using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject menu = null;
    private bool isShowing = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);

            if (menu.active == isShowing)
            {
                Cursor.lockState = CursorLockMode.None;
            }
        }

    }

    public void StartGame()
    {
        // Loads the Game scene
        isShowing = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("MainRoom");
    }

    public void BackToMainMenu()
    {
        // Loads the Main Menu scene
        isShowing = false;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        // Ends the program
        Application.Quit();
    }

    public void Controls()
    {
        menu.SetActive(!menu.active);
    }

}
