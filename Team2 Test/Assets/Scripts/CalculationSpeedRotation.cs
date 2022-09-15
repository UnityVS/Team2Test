using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class CalculationSpeedRotation : MonoBehaviour
{
    public int NumberOfWormWheelWeeth=2; // Z2 - количесвто  зубьев червячного колеса входящие в зацепление
    public int NumberWormVisit=1;  // Z1 - количесвто заходов червяка

    //Формула для расчета передаточного чилса U =Z2/Z1, в червячном зацеплении передаточное число раавно передаточному отношению

    public int GearRatio { get; set; }

    public float SpeedWorm;
    public float SpeedWormWheel { get; set; }

    private void Update()
    {
        СalculationGearRatio(NumberOfWormWheelWeeth, NumberWormVisit);
        CalculateSpeedRotate(SpeedWorm, GearRatio);
        
    }

    public int СalculationGearRatio(int numberOfWormWheelWeeth, int numberWormVisit)
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
