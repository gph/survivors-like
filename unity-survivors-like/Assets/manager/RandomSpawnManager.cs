using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 cameraPosition;
    public int numberOfEnemies;
    public GameObject enemy;
    private int lastPos;
    private List<GameObject> enemySpawned = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition = Camera.main.transform.position;
        Debug.Log(enemySpawned.Count);
        if (enemySpawned.Count < numberOfEnemies)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Debug.Log("Enemy Spawn");
        enemySpawned.Add(Instantiate(enemy, new Vector3(cameraPosition.x + 500, cameraPosition.y + GetRandomValue(- 250, 250), transform.position.z), new Quaternion()));
        enemySpawned.Add(Instantiate(enemy, new Vector3(cameraPosition.x - 500, cameraPosition.y + GetRandomValue(- 250, 250), transform.position.z), new Quaternion()));
        enemySpawned.Add(Instantiate(enemy, new Vector3(cameraPosition.x + GetRandomValue(-500 , 500), cameraPosition.y + 250, transform.position.z), new Quaternion()));
        enemySpawned.Add(Instantiate(enemy, new Vector3(cameraPosition.x + GetRandomValue(-500 , 500) , cameraPosition.y - 250, transform.position.z), new Quaternion()));
    }

    float GetRandomValue(float start, float end)
    {
        return Random.Range(start, end);
    }
    
}