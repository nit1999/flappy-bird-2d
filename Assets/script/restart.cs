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

 
    public void Restart1Game()
    {
        SceneManager.LoadScene("next1");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("menu");
    }
    
}
