using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectorInfo : MonoBehaviour
{
    public int crimeLevel;
    public int crimeRate;
    public int incomePerTurn;


    public int selectedAction;
    //0 = none
    //1 = cut a deal
    //2 = fight crime

    GameObject manager;

    public void Start()
    {
        manager = GameObject.Find("Manager");
        manager.GetComponent<TurnManager>().sectors.Add(gameObject);

        crimeLevel = Random.Range(0, 15);
        crimeRate = Random.Range(1, 15);
        incomePerTurn = Random.Range(100, 500);
    }

    public void Action()
    {
        
    }

    public void UpdateSector()
    {
        crimeLevel += crimeRate;
        manager.GetComponent<PlayerMoney>().totalMoney += incomePerTurn;
    }
}
