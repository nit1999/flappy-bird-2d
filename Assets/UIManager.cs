using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ScoreText;
    public int score;


    public void UpdateScore()
    {
        score += 2;
        ScoreText.text = "Score : " + score;
    }
}
 