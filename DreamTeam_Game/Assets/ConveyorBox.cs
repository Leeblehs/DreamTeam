using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Animal")
        {
            // Destroy(gameObject);
             Debug.Log("Set active");

             col.gameObject.SetActive(false);
             
        }
    }
}