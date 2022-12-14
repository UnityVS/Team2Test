using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform Worm;
    public Transform WormWheel;
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
        Worm.Rotate(transform.up * _calculationSpeedRotation.SpeedWorm * Time.deltaTime);
        WormWheel.Rotate(transform.forward * _calculationSpeedRotation.SpeedWormWheel * Time.deltaTime);

    }
}
