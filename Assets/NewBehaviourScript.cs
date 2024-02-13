using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 direction;
    public float jumpForce = 1000.0f;
    void Update()
    {
        // Получение направления движения
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        // Перемещение персонажа
        transform.Translate(direction * speed * Time.deltaTime);

        // Анимация ходьбы
        if (direction != Vector3.zero)
        {
            // Анимация ходьбы влево/вправо
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // При нажатии кнопки прыжка
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        // Звук шагов
        if (direction != Vector3.zero)
        {
            // Воспроизведение звука шагов
        }
        transform.rotation = Quaternion.Euler(0.0f, transform.rotation.eulerAngles.y, 0.0f);
        // Проверка столкновений
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, 0.5f))
        {
            // Обработка столкновения
        }
        {
            // Увеличение скорости падения
            GetComponent<Rigidbody>().AddForce(Vector3.down * 100.0f, ForceMode.Force);
        }

    }
}