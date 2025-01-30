using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �������� �������� ���������
    public float lookSpeed = 2.0f; // �������� �������� ������


    void Update()
    {
        // �������� ���������
       
        float moveLeftRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        // �������� ������
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;

        transform.localRotation =  Quaternion.Euler(0, moveLeftRight, 0);
    }
}
