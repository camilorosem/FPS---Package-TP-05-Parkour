using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{

    public float money;
    public UIManager uimanager;
    void Start()
    {
        uimanager = FindObjectOfType<UIManager>();
    }


    public bool UpdateMoney(float amount)
    {
        if(money -amount < 0)
        {
            // Intervenir compra
            Debug.Log("Dinero Insuficiente");
            return false;
        }
        else
        {
            money += amount;
            uimanager.UpdateMoneyText(money.ToString());
            return true;
        }
    }
}
    
 