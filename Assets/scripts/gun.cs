using UnityEngine;

public class gun : MonoBehaviour
{
    public float rotationSpeed = 5.0f; // �������� ��������

    void Update()
    {
        // �������� �������������� �������� ����
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        // ������� ������ ������ ��� Y
        transform.Rotate(0, mouseX, 0);
    }
}
