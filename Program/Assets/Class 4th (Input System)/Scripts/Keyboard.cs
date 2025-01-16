using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    private Vector3 direction;
    public float speed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // Time.deltaTime��?
        // ������ �������� �Ϸ�� �� ����� �ð��Դϴ�.
        
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
