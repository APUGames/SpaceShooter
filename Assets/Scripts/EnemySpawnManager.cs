using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

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
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            currentQueueTime = queueTime;
        }
        else
        {
            currentQueueTime -= Time.deltaTime;
        }
    }
}
