using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // ��������� ����������� ������ � �������� ��������� ������
            float y = UnityEngine.Random.Range(0.59f, 2.43f); // ���������� float
            float x = UnityEngine.Random.Range(-9.79f, 10.05f); // ���������� float

            // ������������� ����� �������
            transform.position = new Vector3(x, y, transform.position.z);

            // ����������� ���� ������
            ScoreManager.instance.AddScore(1);
        }
    }
}
