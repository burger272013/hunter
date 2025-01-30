using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // ���������� ������, � ������� �����������
        Destroy(collision.gameObject);

        // ���������� ��� ������
        Destroy(gameObject);
    }
}
