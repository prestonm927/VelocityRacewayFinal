using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel; // Reference to the PausePanel
    private bool isPaused = false;

    void Update()
    {
        // Check for pause input
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        // Activate pause menu UI
        pausePanel.SetActive(true);

        // Stop in-game time
        Time.timeScale = 0f;
        isPaused = true;

        // Optionally lock the cursor or change cursor state if needed
        // Cursor.lockState = CursorLockMode.None;
        // Cursor.visible = true;
    }

    public void ResumeGame()
    {
        // Hide pause menu UI
        pausePanel.SetActive(false);

        // Resume normal time
        Time.timeScale = 1f;
        isPaused = false;

        // Optionally revert cursor state
        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;
    }

    public void QuitGame()
    {
        // For Editor:
        // UnityEditor.EditorApplication.isPlaying = false;

        // For Build:
        Application.Quit();
    }
}
