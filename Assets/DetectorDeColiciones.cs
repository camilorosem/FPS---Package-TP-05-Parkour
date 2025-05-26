using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeColiciones : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto con" + collision.gameObject.name);
        if (collision.gameObject.name == "Players")
        {
            Destroy(gameObject);
        }
    }
}
