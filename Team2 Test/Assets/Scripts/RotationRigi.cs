using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationRigi : MonoBehaviour
{
    public Rigidbody Worm;
    public Rigidbody WormWheel;
    private CalculationSpeedRotation _calculationSpeedRotation;
    public int DirectionValue=-1;
    


    private void Start()
    {
        _calculationSpeedRotation = FindObjectOfType<CalculationSpeedRotation>();
        WormWheel.maxAngularVelocity = Mathf.Infinity;
        Worm.maxAngularVelocity = Mathf.Infinity;
    }
    private void FixedUpdate()
    {
        CalculateSpeedRotation();
        Debug.Log("Speed Worm Wheel " + _calculationSpeedRotation.SpeedWormWheel);

    }

    private void CalculateSpeedRotation()
    {
        Worm.angularVelocity = transform.right * _calculationSpeedRotation.SpeedWorm * Time.fixedDeltaTime* DirectionValue;
        WormWheel.angularVelocity =transform.forward * _calculationSpeedRotation.SpeedWormWheel * Time.fixedDeltaTime* DirectionValue;

    }

    public void ChangeDirectionValueClockwise()
    {
        DirectionValue = -1;
    }

    public void ChangeDirectionValueCounterClockwise()

    {
        DirectionValue = 1;
    }
}
