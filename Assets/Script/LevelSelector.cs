using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    private string levelToLoad = "SampleScene";
    public SceneFader fader;
    public void Play()
    {
        fader.FadeTo(levelToLoad);
    }
}
