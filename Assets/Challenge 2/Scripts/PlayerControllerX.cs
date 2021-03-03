using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogSpawnCooldawn = 0.9f;
    private float dogSpawnTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if ((Time.time - dogSpawnTime) >= dogSpawnCooldawn)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogSpawnTime = Time.time;
            }
        }
    }
}
