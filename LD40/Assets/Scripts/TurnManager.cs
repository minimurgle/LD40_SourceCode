using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour {

    public int currentTurn;

    public SectorInfoPanel infoPanel;

    public List<GameObject> sectors;

    public Text warningText;

    public SelectSector selectSector;

    public GameObject sectorInfoPanel;

    public PowerAndAproval powAndAprov;

	public void EndTurn()
    {
        if (sectorInfoPanel.activeInHierarchy == false)
        {
            currentTurn += 1;
            foreach (GameObject sector in sectors)
            {
                sector.GetComponent<SectorInfo>().UpdateSector();
            }
            infoPanel.SetInfo();
            powAndAprov.UpdatePowerAndAproval();
        }
    }


}
