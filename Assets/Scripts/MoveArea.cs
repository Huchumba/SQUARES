using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArea : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    void Update()
    {
        float step = speed;
        transform.position = Vector3.Lerp(transform.position, target.position, step);
    }
}
