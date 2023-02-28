using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    public string debugName;

    public Vector3[] spawnPoints;

    [SerializeField]
    private float queueTime = 2.0f;
    private float currentQueueTime;

    [SerializeField]
    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        currentQueueTime = queueTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentQueueTime < 0f)
        {
            // Debug.Log(debugName + " " + transform.position);
            int spawnLocationIndex = Random.Range(0, spawnPoints.Length);
            Vector3 spawnLocation = spawnPoints[spawnLocationIndex];
            GameObject enemy = Instantiate(enemyPrefab, spawnLocation, Quaternion.identity);
            enemy.GetComponent<EnemyController>().SetSpeed(speed);
            currentQueueTime = queueTime;
        }
        else
        {
            currentQueueTime -= Time.deltaTime;
        }
    }
}
