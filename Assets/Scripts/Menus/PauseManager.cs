using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Reference to the Pause Menu Panel

    private bool isPaused = false;

    private void Update()
    {
        // Check if ESC key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Pause the game
            pauseMenuPanel.SetActive(true); // Show the pause menu
        }
        else
        {
            Time.timeScale = 1f; // Resume the game
            pauseMenuPanel.SetActive(false); // Hide the pause menu
        }
    }
}
