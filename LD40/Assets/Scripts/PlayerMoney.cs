using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour {

    public int totalMoney = 1000;
    public Text moneyText;

    public void Update()
    {
        moneyText.text = "$" + totalMoney.ToString();
    }
	
}
