﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;

    public IEnumerator SpawnerCoroutine(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);

            Instantiate(prefabs[Random.Range(0, prefabs.Length)], transform.position, transform.rotation);
        }
    }
}
