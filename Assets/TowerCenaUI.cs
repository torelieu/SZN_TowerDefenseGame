using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerCenaUI : MonoBehaviour
{
    public Text towerCenaText;

    // Update is called once per frame
    void Update()
    {
        towerCenaText.text = "Tower: " +  BuildManager.cena.ToString() + "$";
    }
}
