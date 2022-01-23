using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ConveyorObject")
        {
             Destroy(gameObject);
             Debug.Log("Collided");
        }
    }
}