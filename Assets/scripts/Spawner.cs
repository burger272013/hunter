using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject animal;
    private float minSpawnInterval = 2f; // ����������� �������� ������
    private float maxSpawnInterval = 5f; // ������������ �������� ������

    void Start()
    {
        // ��������� ����� ������ ������ ����� ��������� �����
        Invoke("SpawnAnimal", Random.Range(minSpawnInterval, maxSpawnInterval));
    }

    void SpawnAnimal()
    {
        Instantiate(animal, animal.transform.position, animal.transform.rotation);

        // ������������ ���������� ������ ������ ������ ����� ��������� �����
        Invoke("SpawnAnimal", Random.Range(minSpawnInterval, maxSpawnInterval));
    }
}
