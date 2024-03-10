using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string levelToLoad = "LevelSelect";

    public SceneFader sceneFader;
    public void Play()
    {
       sceneFader.FadeTo(levelToLoad);
    }

    public void Quit() 
    {
        Application.Quit();
    }

}
