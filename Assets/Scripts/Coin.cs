using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Случайное перемещение монеты в пределах указанных границ
            float y = UnityEngine.Random.Range(0.59f, 2.43f); // Используем float
            float x = UnityEngine.Random.Range(-9.79f, 10.05f); // Используем float

            // Устанавливаем новую позицию
            transform.position = new Vector3(x, y, transform.position.z);

            // Увеличиваем счёт игрока
            ScoreManager.instance.AddScore(1);
        }
    }
}
