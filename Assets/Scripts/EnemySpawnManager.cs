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
            Instantiate(enemyPrefab, spawnLocation, Quaternion.identity);
            currentQueueTime = queueTime;
        }
        else
        {
            currentQueueTime -= Time.deltaTime;
        }
    }
}
