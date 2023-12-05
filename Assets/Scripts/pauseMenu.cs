using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private bool gameIsPaused = false;
    public GameObject pausePanel;
   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
                resumeGame();
            else
                pauseGame();
        }
    }

    public void resumeGame()
    {
        pausePanel.SetActive(false);
        Cursor.visible = false;
        gameIsPaused = false;
        Time.timeScale = 1.0f;
    }

    public void pauseGame()
    {
        pausePanel.SetActive(true);
        Cursor.visible = true;
        gameIsPaused = true;
        Time.timeScale = 0f;
    }

    public void quitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}