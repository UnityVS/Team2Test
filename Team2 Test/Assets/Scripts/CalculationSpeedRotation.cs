using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class CalculationSpeedRotation : MonoBehaviour
{
    public int NumberOfWormWheelWeeth=2; // Z2 - ����������  ������ ���������� ������ �������� � ����������
    public int NumberWormVisit=1;  // Z1 - ���������� ������� �������

    //������� ��� ������� ������������� ����� U =Z2/Z1, � ��������� ���������� ������������ ����� ������ ������������� ���������

    public int GearRatio { get; set; }

    public float SpeedWorm;
    public float SpeedWormWheel { get; set; }

    private void Update()
    {
        �alculationGearRatio(NumberOfWormWheelWeeth, NumberWormVisit);
        CalculateSpeedRotate(SpeedWorm, GearRatio);
        
    }

    public int �alculationGearRatio(int numberOfWormWheelWeeth, int numberWormVisit)
    {
        GearRatio = numberOfWormWheelWeeth / numberWormVisit;
        return GearRatio;
    }

    public float CalculateSpeedRotate(float speedWorm, int gearRatio)
    {      
        SpeedWormWheel = speedWorm * gearRatio;
        return SpeedWormWheel;
    }
}
