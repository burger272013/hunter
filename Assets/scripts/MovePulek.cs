using UnityEngine;

public class MovePulek : MonoBehaviour
{
    public float speed = 5.0f; // Скорость движения животного

    void Update()
    {
        // Перемещаем объект вперед по его локальной оси Z
        transform.Translate(Vector3.back *  speed * Time.deltaTime);
    }
}
