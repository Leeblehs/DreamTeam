using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberOfPrefabs;
    public GameObject[] prefabPool;

    // Start is called before the first frame update
    void Start()
    {
        prefabPool = new GameObject[numberOfPrefabs];
        prefabCreation();
    }

    public void prefabCreation()
    {
        for (int i = 0; i < prefabPool.Length; i++)
        {
            Instantiate(prefabPool[i]);

            // https://forum.unity.com/threads/how-to-reference-prefabs-before-instantiation.409874/
            // https://answers.unity.com/questions/973857/instantiating-prefabs-from-array.html
            // https://docs.unity3d.com/ScriptReference/Resources.Load.html

            // The object I want to instantiate is null error, perhaps I have to load it beforehand?
            // Ask tutor

        }
    }
}
