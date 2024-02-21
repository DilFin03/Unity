using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Перевіряємо, чи зіткнувся об'єкт з лавою
        if (collision.gameObject.CompareTag("ObjectToDelete"))
        {
            // Видаляємо об'єкт зі сцени
            Destroy(collision.gameObject);
        }
    }
}

