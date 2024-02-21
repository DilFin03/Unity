using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // ����������, �� �������� ��'��� � �����
        if (collision.gameObject.CompareTag("ObjectToDelete"))
        {
            // ��������� ��'��� � �����
            Destroy(collision.gameObject);
        }
    }
}

