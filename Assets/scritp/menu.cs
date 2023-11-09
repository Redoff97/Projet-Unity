using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            pauseMenu.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Continue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()

    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
