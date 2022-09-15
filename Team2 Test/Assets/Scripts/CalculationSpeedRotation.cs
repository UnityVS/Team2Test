using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class CalculationSpeedRotation : MonoBehaviour
{
    public int NumberOfWormWheelWeeth = 2; // Z2 - ����������  ������ ���������� ������ �������� � ����������
    [Range(1, 4)]
    public int NumberWormVisit=1;  // Z1 - ���������� ������� �������

    //������� ��� ������� ������������� ����� U =Z2/Z1, � ��������� ���������� ������������ ����� ������ ������������� ���������

    public int GearRatio { get; set; }

    public float SpeedWorm;
    public float SpeedWormWheel { get; set; }

    [SerializeField] Text CanvasNumberOfWormWheelWeeth;
    [SerializeField] Text CanvasNumberWormVisit;
    [SerializeField] Text CanvasGearRatio;
    [SerializeField] Text CanvasSpeedWorm;
    [SerializeField] Text CanvasWheelSpeedWorm;

    private void Update()
    {
        �alculationGearRatio(NumberOfWormWheelWeeth, NumberWormVisit);
        CalculateSpeedRotate(SpeedWorm, GearRatio);
        CanvasNumberOfWormWheelWeeth.text =  NumberOfWormWheelWeeth.ToString();
        CanvasNumberWormVisit.text =   NumberWormVisit.ToString();
        CanvasGearRatio.text = "������������ ���������: " + GearRatio.ToString();
        CanvasSpeedWorm.text = "������������� ������: " + SpeedWorm.ToString();
        CanvasWheelSpeedWorm.text = "�������� ������: " + SpeedWormWheel.ToString();
    }

    public int �alculationGearRatio(int numberOfWormWheelWeeth, int numberWormVisit)
    {
        GearRatio = numberOfWormWheelWeeth / numberWormVisit;
        return GearRatio;
    }

    public float CalculateSpeedRotate(float speedWorm, int gearRatio)
    {      
        SpeedWormWheel = speedWorm / gearRatio;
        return SpeedWormWheel;
    }


    public void IncreaseNumberOfWormWheelWeeth()
    {
        NumberOfWormWheelWeeth++;
    }
    public void DecreaseNumberOfWormWheelWeeth()
    {
        NumberOfWormWheelWeeth--;
    }
    public void IncreaseNumberWormVisit()
    {
        NumberWormVisit ++;
    }
    public void DecreaseNumberWormVisit()
    {
        NumberWormVisit--;
    }

    public void IncreaseSpeedWorm()
    {
        SpeedWorm += 25f;
    }
    public void DecreasSpeedWorm()
    {
        SpeedWorm -= 25f;
    }

   
}
