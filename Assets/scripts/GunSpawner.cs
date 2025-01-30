using UnityEngine;

public class GunSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // Префаб пули
    public Transform bulletSpawnPoint; // Точка спавна пули
    public float bulletSpeed = 10.0f; // Скорость пули

    void Update()
    {
        // Проверяем, нажата ли кнопка мыши
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Создаем пулю из префаба
        Instantiate(bulletPrefab, bulletSpawnPoint.position,transform.rotation);
    }
}
