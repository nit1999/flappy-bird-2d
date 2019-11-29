using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseScreen : MonoBehaviour
{

    public void pauseScrn()
    {
        Time.timeScale = 0;

    }
    public void PlayScrn()
    {
        Time.timeScale = 1;
    }

}
