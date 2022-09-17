using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


[ExecuteAlways]
public class CalculationSpeedRotation : MonoBehaviour
{
    public float NumberOfWormWheelTooth { get; set; } = 2; // Z2 - количесвто  зубьев червячного колеса входящие в зацепление
    public float MinNumberOfWormWheelTooth = 1;
    public float MaxNumberOfWormWheelTooth = 30;
    public float NumberWormVisit { get; set; } = 1;  // Z1 - количесвто заходов червяка
    public float MinNumberWormVisit = 1;
    public float MaxNumberWormVisit = 6;
    

    public float GearRatio { get; set; } //Расчет передаточного чилса U =Z2/Z1, в червячном зацеплении передаточное число раавно передаточному отношению, так написано в интернете))
    public float SpeedWorm;
    public float SpeedWormWheel { get; set; }

    [SerializeField] TextMeshProUGUI CanvasNumberOfWormWheelWeeth;
    [SerializeField] TextMeshProUGUI CanvasNumberWormVisit;
    [SerializeField] TextMeshProUGUI CanvasGearRatio;
    [SerializeField] TextMeshProUGUI CanvasSpeedWorm;
    [SerializeField] TextMeshProUGUI CanvasWheelSpeedWorm;

    private void Update()
    {
        СalculationGearRatio(NumberOfWormWheelTooth, NumberWormVisit);
        CalculateSpeedRotate(SpeedWorm, GearRatio);
        CanvasNumberOfWormWheelWeeth.text =  NumberOfWormWheelTooth.ToString();
        CanvasNumberWormVisit.text =   NumberWormVisit.ToString();
        CanvasGearRatio.text = "Передаточное отношение: " + GearRatio.ToString();
        CanvasSpeedWorm.text = "Начальная угловая скорость: " + (SpeedWorm*9.5).ToString("0") + " об/мин";
        CanvasWheelSpeedWorm.text = "Выходная угловая скорость: " + (SpeedWormWheel*9.5).ToString("0") + " об/мин";       
    }

    public float СalculationGearRatio(float numberOfWormWheelWeeth, float numberWormVisit)
    {
        GearRatio = Mathf.Clamp(numberOfWormWheelWeeth,MinNumberOfWormWheelTooth,MaxNumberOfWormWheelTooth)/ Mathf.Clamp(numberWormVisit,MinNumberWormVisit,MaxNumberWormVisit);
        return GearRatio;
    }

    public float CalculateSpeedRotate(float speedWorm, float gearRatio)
    {      
        SpeedWormWheel = speedWorm / gearRatio;
        return SpeedWormWheel;
    }



   
}
