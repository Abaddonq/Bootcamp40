using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PertainingToLife : MonoBehaviour
{

    // Karakter bunlar� toplad��� s�rece hayatta kalabilecek 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
