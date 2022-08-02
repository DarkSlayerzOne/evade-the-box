using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // private float m_SpawnInterval = 2.0f;
    // private float m_Timer = 0;

    public Vector2 spawnRangeX;

    void Start()
    {
         InvokeRepeating("SpawnEnemy", 0, 2.0f);

    }

    // void Update()
    // {
    //     m_Timer += Time.deltaTime;

    //     if (m_Timer >= m_SpawnInterval) 
    //     {
    //         Instantiate(enemyPrefab);
    //         m_Timer = 0;
    //     }
 
    // }

    private void SpawnEnemy() 
    {
        Vector3 spawnPosition = new Vector3(
                Random.Range(spawnRangeX[0], spawnRangeX[1]),
                enemyPrefab.transform.position.y,
                enemyPrefab.transform.position.z);

        Instantiate(enemyPrefab, 
                spawnPosition, 
                enemyPrefab.transform.rotation);

    }





}
