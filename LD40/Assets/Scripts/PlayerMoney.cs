using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour {

    public int totalMoney = 1000;
    public Text moneyText;
    public Text gameOver;

    public void Update()
    {
        moneyText.text = "$" + totalMoney.ToString();

        if (totalMoney <= 0)
        {
            totalMoney = 0;
            gameOver.gameObject.SetActive(true);
            //Submit score here maybe?
        }
    }
	
}
