using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    // references to your objects
    public GameObject[] pooledObjects;

    // call instead of Instantiate
    public GameObject RecruitFreeObject()
    {
        // browse them all
        // whenever you see a disabled object, enable it then return it
        // if you can't find one, return null

        return null;
    }

    // call instead of destroy
    public void SendObjectBackToPool(GameObject obj)
    {
        // disable obj
        // reinitialize everything
    }
}


