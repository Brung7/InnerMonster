
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    public GameObject obj;
    private float randomX;
    Vector2 whereToSpawn;
    public float spawnDelay;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnDelay;
            randomX = Random.Range(-10, 10);
            whereToSpawn = new Vector3(randomX, transform.position.y, 0);
            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
            Destroy(Enemy, 1.7f);
        }
    }
}
