using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSector : MonoBehaviour {

    public GameObject selectedSector;
    public GameObject infoPanel;

    void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            CastRayToClick();
        }
	}

    void CastRayToClick()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Sector")
        {
            Debug.Log(hit.collider.gameObject.name);
            selectedSector = hit.collider.gameObject;
            infoPanel.GetComponent<SectorInfoPanel>().OpenInfoPanel();
        }
    }

    
}
