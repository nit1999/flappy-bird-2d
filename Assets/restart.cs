using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : Player
{
    public Text totalTextscore;
   
    public void Start()
    {
      //  Debug.Log(totalCount);
        totalTextscore.text = "" + totalCount;
    }
 
    public void RestartGame()
    {

        SceneManager.LoadScene("gameScene");
    

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("menu");
    }
    
}
