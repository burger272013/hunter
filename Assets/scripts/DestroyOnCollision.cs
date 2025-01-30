using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // ”ничтожаем объект, с которым столкнулись
        Destroy(collision.gameObject);

        // ”ничтожаем сам объект
        Destroy(gameObject);
    }
}
