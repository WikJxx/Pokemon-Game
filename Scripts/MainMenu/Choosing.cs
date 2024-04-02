using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choosing : MonoBehaviour
{
    
   public void Game1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Game2()
    {
        SceneManager.LoadScene("MemoScene");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
