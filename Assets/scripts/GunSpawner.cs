using UnityEngine;

public class GunSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // ������ ����
    public Transform bulletSpawnPoint; // ����� ������ ����
    public float bulletSpeed = 10.0f; // �������� ����

    void Update()
    {
        // ���������, ������ �� ������ ����
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // ������� ���� �� �������
        Instantiate(bulletPrefab, bulletSpawnPoint.position,transform.rotation);
    }
}
