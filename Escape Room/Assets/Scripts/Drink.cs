using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem poof;

    private void OnMouseDown()
    {
        gameManager.BackToMainMenu();
    }

    private void OnEnable()
    {
        poof.Play();
    }
}
