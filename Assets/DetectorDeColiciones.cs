using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeColiciones : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
    {
        UnityEngine.Debug.Log("Contacto");
        Destroy(collision.gameObject);
    }
}
