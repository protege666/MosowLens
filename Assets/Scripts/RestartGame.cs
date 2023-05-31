using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void QuitGame() 
    {
        {
            Application.Quit();
        }
    }

    
    public void Restart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
