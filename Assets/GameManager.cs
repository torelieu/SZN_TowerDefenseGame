using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameIsOver = false;
    [SerializeField]
    public GameObject gameOverUI;

    public static bool gameIsWin = false;
    [SerializeField]
    public GameObject gameWinUI;
    // Update is called once per frame

    private void Start()
    {
        gameIsOver= false;
    }
    void Update()
    {
        if (gameIsOver)
            return;

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if (PlayerStats.Lives <= 0 )
        {
            EndGame();
        }

        if(Input.GetKeyDown("w")) 
        {
            WinGame();
        }
    }

    private void EndGame()
    {
        gameIsOver = true;
        Debug.Log("Game Over!");
        gameOverUI.SetActive(true);

    }

    private void WinGame()
    {
        gameIsWin = true;
        gameWinUI.SetActive(true);

    }
}
