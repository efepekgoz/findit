using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        Destroy(GameObject.Find("Menu"));
    }

public void QuitGame()
    {
        Application.Quit();
    }

}
