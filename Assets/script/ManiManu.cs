using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManiManu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void DarkMode()
    {
        SceneManager.LoadScene("next1");
    }
    public void quit()
    {
        Application.Quit();
    }
}
