using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject obj;
     float RandX;
     private Vector2 whereToSpawn;
     [SerializeField] private float spawnRate = 2f;
     private float nextSpawn = 0.0f;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-9.23f,9.24f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            GameObject enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
            Destroy(enemy, 1.7f);
        }
        
    }
}
