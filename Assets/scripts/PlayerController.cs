using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Скорость движения персонажа
    public float lookSpeed = 2.0f; // Скорость вращения камеры


    void Update()
    {
        // Движение персонажа
       
        float moveLeftRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        // Вращение камеры
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;

        transform.localRotation =  Quaternion.Euler(0, moveLeftRight, 0);
    }
}
