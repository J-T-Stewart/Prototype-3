using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    private Vector3 spawnPos = new Vector3(25, 1.5f, 0);
    private PlayerController playerControllerScript;

    private float startDelay = 2.0f;
    private float repeatRate = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle() {
        int random = Random.Range(0, obstaclePrefabs.Length);
        if (playerControllerScript.gameOver == false) {
            Instantiate(obstaclePrefabs[random], spawnPos, obstaclePrefabs[random].transform.rotation);
        }
    }
}
