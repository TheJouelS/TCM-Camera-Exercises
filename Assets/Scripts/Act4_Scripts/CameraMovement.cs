using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 0;

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.position = transform.position + direction.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "WayPoint")
        {
            target = collision.gameObject.GetComponent<WPScript>().nextPoint;
        }
    }
}
