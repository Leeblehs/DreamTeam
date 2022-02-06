using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExample : MonoBehaviour
{
   
   public int currentGameLevel = 0;
   public int maxGameLevel = 10;

   public GameObject[] animalPrefabs;
   public GameObject[] animals;

   public Rigidbody2D rb;


   public void BeginRound()
   {
        animals = new GameObject[animalPrefabs.Length]; //makes sure they match length
        if(currentGameLevel < maxGameLevel)
        {
            for (int i = 0; i < currentGameLevel; i++)
            {   
                // add a rb  and collider, but I dont think I can bc its readonly / references
                // super scuffed method but with these it works
                // can add them to prefab but it would ruin uses in other levels
                // potentially worth adding and removing from other scenes just so we can get an example
                 int index = Random.Range(0, animalPrefabs.Length);
                 animals[i] = Instantiate(animalPrefabs[index], new Vector2(i * -1.0F, 0), Quaternion.identity) as GameObject;
            }          
        }

        currentGameLevel++;
   }
   




}
