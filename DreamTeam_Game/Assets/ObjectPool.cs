using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    // In order to access our ObjectPool from other classes, without having a reference to it
    public static ObjectPool instance;
    
    private List<GameObject> pooledObjects = new List<GameObject>();
    public Animal[] animalTypes;
    private int amountToPool = 20;
    public int currentGameLevel = 0;
    public int maxGameLevel = 10;
    
    [SerializeField] private GameObject animalPrefab;
    [SerializeField] private Transform animalPosition;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        // Creates new instances of animalPrefab equal to the amount of amountToPool (20 currently)
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(animalPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        // 
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

    public void SpawnPooledObject()
    {
        if(currentGameLevel < maxGameLevel)
        {
             for (int i = 0; i < currentGameLevel; i++)
             {
                 GameObject animal = ObjectPool.instance.GetPooledObject();
                 if (animal != null)
                 {
                    animal.transform.position = animalPosition.position;
                    animal.SetActive(true); 
                    int index = Random.Range(0, animalTypes.Length);
                    SetSprite(animal, animalTypes[index]);
                    SetAnimation(animal,animalTypes[index]);
                     
                    
                    // add the scriptable object
                    // wait some seconds between spawns


                    
                 }
             }

            // Loops an extra time per game level, add this to a button that hides on click
            // make new function for this?
            currentGameLevel++;
        }
    }
    public void SetSprite(GameObject animal, Animal animalProperties)
    {
        SpriteRenderer spriteRenderer = animal.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = animalProperties.artwork;
    }
    public void SetAnimation(GameObject animal, Animal animalProperties)
    {
        AnimalProperties animalObject = animal.GetComponent<AnimalProperties>();
        animalObject.PlayAnimation(animalProperties.name);
    }
}


// notes
// set position to self position instead of animal position (as this script will be on the spawner anyways)
// maybe its worth keeping it the way it is
