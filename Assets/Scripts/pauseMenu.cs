using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool Gamepause = false;

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Gamepause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Gamepause = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Gamepause = true;
    }

    public void Menu() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Gamepause = false;
        SceneManager.LoadScene("Menu");
    }

}
