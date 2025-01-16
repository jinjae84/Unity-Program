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
        // Time.deltaTime란?
        // 마지막 프레임이 완료된 후 경과한 시간입니다.
        
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
