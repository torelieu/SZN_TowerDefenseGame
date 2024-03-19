using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    public static int cena = 100;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    public GameObject standartTurretPrefab;

    void Start()
    {
        turretToBuild = standartTurretPrefab;
    }


    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {

        if (PlayerStats.Money >= cena)
        {
            PlayerStats.Money -= cena;
            cena += 50;
            Debug.Log(cena);
            return turretToBuild;
        }
        else { 

                return null;
            }
        

    }
}
