using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtVida;
    public MoneyManager moneyManager;

   public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }
    public void UpdateVidaText(string health)
    {
        txtVida.text = health;
    }
}
