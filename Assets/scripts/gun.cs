using UnityEngine;

public class gun : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // Скорость вращения

    void Update()
    {
        // Получаем горизонтальное движение мыши
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        // Вращаем объект вокруг оси Y
        transform.Rotate(0, mouseX, 0);
    }
}
