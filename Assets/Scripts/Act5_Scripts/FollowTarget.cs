using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    //Alternativa 1
    private Vector3 _direction = Vector3.zero;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = target.position.x;
        pos.y = target.position.y;

        //Alternativa 1
        //_direction = pos - transform.position;
        //transform.position = transform.position + _direction.normalized * speed * Time.deltaTime;

        //Alternativa 2
        transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
    }
}
