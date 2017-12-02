using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SectorInfoPanel : MonoBehaviour {

    public Text sectorNamelabel;
    public GameObject infoPanel;

    public SelectSector selectsector;



    public void OpenInfoPanel()
    {
        infoPanel.SetActive(true);
        sectorNamelabel.text = selectsector.selectedSector.name;
    }

    public void ClosePanel()
    {
        infoPanel.SetActive(false);
    }
}
