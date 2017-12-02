﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SectorInfoPanel : MonoBehaviour {

    [Header("Text Labels")]
    public Text sectorNamelabel;
    public Text crimeRateText;
    public Text crimeLevelText;
    public Text incomeText;
    public Dropdown actionDropdown;

    [Space(2)]

    [Header("Actions")]
    public GameObject infoPanel;
    public SelectSector selectsector;
    SectorInfo sectorinfo;

    [Space(2)]

    public Text warningText;


    public void OpenInfoPanel()
    {
        sectorinfo = selectsector.selectedSector.GetComponent<SectorInfo>();
        SetInfo();
        infoPanel.SetActive(true);
    }

    public void SetInfo()
    {
        if (selectsector.selectedSector == null)
        {
            //do nothing
        }
        else
        {
            sectorNamelabel.text = selectsector.selectedSector.name;
            crimeRateText.text = sectorinfo.crimeRate.ToString();
            crimeLevelText.text = sectorinfo.crimeLevel.ToString();
            incomeText.text = sectorinfo.incomePerTurn.ToString();
            actionDropdown.value = sectorinfo.selectedAction;
        }

    }

    public void ClosePanel()
    {
        infoPanel.SetActive(false);
    }

    public void ChooseAction()
    {
        sectorinfo.selectedAction = actionDropdown.value;
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        warningText.gameObject.SetActive(false);
    }
}
