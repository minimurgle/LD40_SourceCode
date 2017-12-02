using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectorInfo : MonoBehaviour
{
    public int crimeLevel;
    public int crimeRate;
    public int incomePerTurn;
    public bool sectorLost;


    public int selectedAction;
    //0 = none
    //1 = cut a deal
    //2 = fight crime

    GameObject manager;

    public void Start()
    {
        manager = GameObject.Find("Manager");
        manager.GetComponent<TurnManager>().sectors.Add(gameObject);

        crimeLevel = Random.Range(0, 20);
        crimeRate = Random.Range(5, 20);
        incomePerTurn = Random.Range(50, 250);
    }

    public void DoAction()
    {
      if (selectedAction == 0)
        {
            //Do nothing
        }
      else if (selectedAction == 1)
        {
            crimeLevel += Random.Range(0, 25);
            manager.GetComponent<PlayerMoney>().totalMoney += Random.Range(100, 300);
        }
      else if (selectedAction == 2)
        {
            crimeLevel -= Random.Range(0, 20);
            manager.GetComponent<PlayerMoney>().totalMoney -= Random.Range(100, 400);
        }
    }

    public void UpdateSector()
    {
        crimeLevel += crimeRate;
        incomePerTurn -= crimeLevel;
        manager.GetComponent<PlayerMoney>().totalMoney += incomePerTurn;
        if (crimeLevel >= 100)
        {
            sectorLost = true;
        }
        DoAction();
        selectedAction = 0;
    }
}
