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
        // ��������� ����������� ��������
        direction = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        // ����������� ���������
        transform.Translate(direction * speed * Time.deltaTime);

        // �������� ������
        if (direction != Vector3.zero)
        {
            // �������� ������ �����/������
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ��� ������� ������ ������
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        // ���� �����
        if (direction != Vector3.zero)
        {
            // ��������������� ����� �����
        }
        transform.rotation = Quaternion.Euler(0.0f, transform.rotation.eulerAngles.y, 0.0f);
        // �������� ������������
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit, 0.5f))
        {
            // ��������� ������������
        }
        {
            // ���������� �������� �������
            GetComponent<Rigidbody>().AddForce(Vector3.down * 100.0f, ForceMode.Force);
        }

    }
}