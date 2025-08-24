using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    public void ResetGame()
    {
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene("S2");
    }
    public void ExitGame()
    {
        Application.Quit();
       // SceneManager.LoadScene(0);
    }
}
