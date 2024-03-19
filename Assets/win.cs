using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    public Text roundsText;

    private void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }



    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
