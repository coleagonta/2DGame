using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject obj;
     float RandX;
     private Vector2 whereToSpawn;
     [SerializeField] private float spawnRate = 2f;
     private float nextSpawn = 0.0f;
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-8f,8f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            GameObject enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
        
    }
}
