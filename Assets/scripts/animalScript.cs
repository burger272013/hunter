using UnityEngine;

public class animalScript: MonoBehaviour
{
    public float speed = 5.0f; // �������� �������� ���������

    void Update()
    {
        // ���������� ������ ������ �� ��� ��������� ��� Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
