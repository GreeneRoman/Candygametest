using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class CandySpawner: MonoBehaviour
{ 
    [SerializeField] float maxX;
    [SerializeField] float spawnInterval;

     public GameObject[] candies;

     public static CandySpawner candinstance;

     private void Awake()
     {
         if (candinstance == null)
         {
             candinstance = this;
         }
     }
    
    
    void Start()
    {
        
        StartSpawningCandies();
    }

    
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        
       int  rand = Random.Range(0, candies.Length);

       float randomX = Random.Range(-maxX, maxX);

       var transform1 = transform;
       var position = transform1.position;
       Vector3 randomPos = new Vector3(randomX, position.y,position.z);

        Instantiate(candies[rand], randomPos, transform1.rotation);

    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);

        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }

   

  
}
