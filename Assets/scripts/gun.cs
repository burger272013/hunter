using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float up;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X");
        vertical = Input.GetAxis("Mouse Y");

        // �������� �� �����������
        transform.Rotate(0, horizontal, 0);

        // �������� �� ���������
        transform.Rotate(0, 0, vertical);
    }
}
