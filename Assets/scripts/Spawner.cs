using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject animal;
    private float minSpawnInterval = 2f; // Минимальный интервал спауна
    private float maxSpawnInterval = 5f; // Максимальный интервал спауна

    void Start()
    {
        // Начальный вызов метода спауна через случайное время
        Invoke("SpawnAnimal", Random.Range(minSpawnInterval, maxSpawnInterval));
    }

    void SpawnAnimal()
    {
        Instantiate(animal, animal.transform.position, animal.transform.rotation);

        // Планирование следующего вызова метода спауна через случайное время
        Invoke("SpawnAnimal", Random.Range(minSpawnInterval, maxSpawnInterval));
    }
}
