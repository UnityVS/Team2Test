using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class CalculationSpeedRotation : MonoBehaviour
{
    public float NumberOfWormWheelTooth = 2; // Z2 - ����������  ������ ���������� ������ �������� � ����������
    public float MinNumberOfWormWheelTooth = 1;
    public float MaxNumberOfWormWheelTooth = 30;
    public float NumberWormVisit=1;  // Z1 - ���������� ������� �������
    public float MinNumberWormVisit = 1;
    public float MaxNumberWormVisit = 6;
    //������� ��� ������� ������������� ����� U =Z2/Z1, � ��������� ���������� ������������ ����� ������ ������������� ���������

    public float GearRatio { get; set; }
    public float SpeedWorm;
    public float SpeedWormWheel { get; set; }

    [SerializeField] Text CanvasNumberOfWormWheelWeeth;
    [SerializeField] Text CanvasNumberWormVisit;
    [SerializeField] Text CanvasGearRatio;
    [SerializeField] Text CanvasSpeedWorm;
    [SerializeField] Text CanvasWheelSpeedWorm;

    private void Update()
    {
        �alculationGearRatio(NumberOfWormWheelTooth, NumberWormVisit);
        CalculateSpeedRotate(SpeedWorm, GearRatio);
        CanvasNumberOfWormWheelWeeth.text =  NumberOfWormWheelTooth.ToString();
        CanvasNumberWormVisit.text =   NumberWormVisit.ToString();
        CanvasGearRatio.text = "������������ ���������: " + GearRatio.ToString();
        CanvasSpeedWorm.text = "������������� ������: " + SpeedWorm.ToString();
        CanvasWheelSpeedWorm.text = "�������� ������: " + SpeedWormWheel.ToString();       
    }

    public float �alculationGearRatio(float numberOfWormWheelWeeth, float numberWormVisit)
    {
        GearRatio = Mathf.Clamp(numberOfWormWheelWeeth,MinNumberOfWormWheelTooth,MaxNumberOfWormWheelTooth)/ Mathf.Clamp(numberWormVisit,MinNumberWormVisit,MaxNumberWormVisit);
       // if (numberOfWormWheelWeeth <= 0)
       // {
       //     GearRatio = 0.1f;
      //  }
            return GearRatio;
    }

    public float CalculateSpeedRotate(float speedWorm, float gearRatio)
    {      
        SpeedWormWheel = speedWorm / gearRatio;
        return SpeedWormWheel;
    }



   
}
