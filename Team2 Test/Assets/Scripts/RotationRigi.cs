using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationRigi : MonoBehaviour
{
    public Rigidbody Worm;
    public Rigidbody WormWheel;
    private CalculationSpeedRotation _calculationSpeedRotation;


    private void Start()
    {
        _calculationSpeedRotation = FindObjectOfType<CalculationSpeedRotation>();
    }
    private void Update()
    {
        CalculateSpeedRotation();
        Debug.Log("Speed Worm Wheel " + _calculationSpeedRotation.SpeedWormWheel);
    }

    private void CalculateSpeedRotation()
    {
        Worm.AddRelativeTorque(transform.up * _calculationSpeedRotation.SpeedWorm * Time.deltaTime);
        WormWheel.AddRelativeTorque(transform.forward * _calculationSpeedRotation.SpeedWormWheel * Time.deltaTime);

    }
}
