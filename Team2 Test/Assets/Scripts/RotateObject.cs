using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] int _rotateionOrientation;
    [SerializeField] float _speed;
    void Update()
    {
        if (_rotateionOrientation == 0)
        {
            transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
        }else if (_rotateionOrientation == 1)
        {
            transform.Rotate(Vector3.down * _speed * Time.deltaTime);
        }
    }
}
