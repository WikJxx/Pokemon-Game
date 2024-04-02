using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject supportMenu;


    public void PlayGame()
    {
        SceneManager.LoadScene("Choosing");
    }

    public void Options()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void Support()
    {
        mainMenu.SetActive(false);
        supportMenu.SetActive(true);
    }
    public void back2()
    {
        mainMenu.SetActive(true);
        supportMenu.SetActive(false);
    }
    public void back()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
        public void ExitGame()
    {
        Application.Quit();
    }
}
