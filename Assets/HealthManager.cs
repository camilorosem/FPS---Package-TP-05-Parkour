using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public UIManager uimanger;
    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }


    public bool UpdateHealth (int damageAmount)
    {
        if(healthPoints <= damageAmount)
        {
            //Mensaje de muerte
            Debug.Log("Estas Muerto");
            return false;
        }
        healthPoints -= damageAmount;
       return true;
    }
}
