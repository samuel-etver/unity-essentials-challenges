using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DogMove : MonoBehaviour
{
    public float RotationSpeed = 0.0f;
    private float _rotationRadius;
    private float _rotationAngle;


    void Start()
    {
        _rotationRadius = Mathf.Sqrt(
            Mathf.Pow(transform.position.x, 2) + 
            Mathf.Pow(transform.position.z, 2));
        if(_rotationRadius > 0.0f)
            _rotationAngle = Mathf.Asin(transform.position.x / _rotationRadius);
    }


    void Update()
    {
        _rotationAngle += RotationSpeed * Time.deltaTime;
        float x = _rotationRadius * Mathf.Sin(_rotationAngle);
        float z = _rotationRadius * Mathf.Cos(_rotationAngle);
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
