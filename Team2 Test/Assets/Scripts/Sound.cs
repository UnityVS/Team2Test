using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource _audioSource;
    private CalculationSpeedRotation _calculationSpeedRotation;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _calculationSpeedRotation = FindObjectOfType<CalculationSpeedRotation>();
    }
    private void Update()
    {
        _audioSource.pitch = _calculationSpeedRotation.SpeedWormWheel/200;
    }
}
