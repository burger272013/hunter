using UnityEngine;

public class MovePulek : MonoBehaviour
{
    public float speed = 5.0f; // �������� �������� ���������

    void Update()
    {
        // ���������� ������ ������ �� ��� ��������� ��� Z
        transform.Translate(Vector3.back *  speed * Time.deltaTime);
    }
}
