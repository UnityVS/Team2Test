using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class CalculationSpeedRotation : MonoBehaviour
{
    public float NumberOfWormWheelTooth = 2; // Z2 - количесвто  зубьев червячного колеса входящие в зацепление
    public float MinNumberOfWormWheelTooth = 1;
    public float MaxNumberOfWormWheelTooth = 30;
    public float NumberWormVisit=1;  // Z1 - количесвто заходов червяка
    public float MinNumberWormVisit = 1;
    public float MaxNumberWormVisit = 6;
    //Формула для расчета передаточного чилса U =Z2/Z1, в червячном зацеплении передаточное число раавно передаточному отношению

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
        СalculationGearRatio(NumberOfWormWheelTooth, NumberWormVisit);
        CalculateSpeedRotate(SpeedWorm, GearRatio);
        CanvasNumberOfWormWheelWeeth.text =  NumberOfWormWheelTooth.ToString();
        CanvasNumberWormVisit.text =   NumberWormVisit.ToString();
        CanvasGearRatio.text = "Передаточное отношение: " + GearRatio.ToString();
        CanvasSpeedWorm.text = "Пикладываемый момент: " + SpeedWorm.ToString();
        CanvasWheelSpeedWorm.text = "Выходной момент: " + SpeedWormWheel.ToString();       
    }

    public float СalculationGearRatio(float numberOfWormWheelWeeth, float numberWormVisit)
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
