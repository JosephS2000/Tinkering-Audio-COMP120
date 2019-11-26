﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] fishes;
    [SerializeField] private float spawnRate = 2f;

    private float nextSpawn = 0.0f;
    private Vector2 spawnPos;
    private float randPosY = 0.0f;

    void Update()
    {
        SpawnFish();
    }

    private void SpawnFish()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            //You can change the pos of where the fishes spawn here             
            randPosY = Random.Range(-3.01f, 4.41f);
        
            Vector2 spawnPos = new Vector2(50.16f, randPosY);
            Instantiate(fishes[Random.Range(0, fishes.Length)], spawnPos, Quaternion.identity);     
        }
    }
}
