using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;
    [SerializeField]
    public GameObject gameOverUI;
    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
            return;


        if (PlayerStats.Lives <= 0 )
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gameEnded = true;
        Debug.Log("Game Over!");
        gameOverUI.SetActive(true);

    }
}
