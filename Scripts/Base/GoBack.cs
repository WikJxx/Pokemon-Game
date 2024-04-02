using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Load2()
    {
        SceneManager.LoadScene("MemoScene");
    }
}
