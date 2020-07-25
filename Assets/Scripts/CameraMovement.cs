using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform _target;    
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(0, 2, -5);

    public void Init(Transform target)
    {
        _target = target;
    }

    private void FixedUpdate()
    {
        if (_target != null)
        {
            transform.position = Vector3.Lerp(transform.position, _target.position + offset, Time.deltaTime * smooth);
        }       
    }
}
