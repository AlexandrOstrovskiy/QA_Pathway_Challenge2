using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;
    private int spawnIntervalMin = 3;
    private int spawnIntervalMax = 5;

    // Start is called before the first frame update
    void Start()
    {
        
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    private void LateUpdate()
    {
        spawnInterval = Random.Range(spawnIntervalMin,spawnIntervalMax + 1);
        Invoke("SpawnRandomBall", spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        new WaitForSeconds(startDelay);
        int ballToSpawnIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        if (GameObject.Find(ballPrefabs[ballToSpawnIndex].name + "(Clone)") == null)
            Instantiate(ballPrefabs[ballToSpawnIndex], spawnPos, ballPrefabs[ballToSpawnIndex].transform.rotation);
    }

}
