using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private CalculationSpeedRotation _calculationSpeedRotation;

    public Button NumberOfWormWheelWeethUp;
    public Button NumberOfWormWheelWeethDown;
    public Button NumberWormVisitUp;
    public Button NumberWormVisitDown;

    public Slider SliderWormWheel;
    public Slider SliderSpeedWorm;
    public Slider SliderWorm;

    private void Awake()
    {
        _calculationSpeedRotation = FindObjectOfType<CalculationSpeedRotation>();
        SliderWormWheel.minValue = _calculationSpeedRotation.MinNumberOfWormWheelTooth;
        SliderWormWheel.maxValue = _calculationSpeedRotation.MaxNumberOfWormWheelTooth;
        SliderSpeedWorm.minValue = -3000f;
        SliderSpeedWorm.maxValue = 3000f;
        SliderWorm.minValue = _calculationSpeedRotation.MinNumberWormVisit;
        SliderWorm.maxValue = _calculationSpeedRotation.MaxNumberWormVisit;


    }

   /* public void InteractableButtonsNumberOfWormWheelWeeth()
    {
        if (_calculationSpeedRotation.NumberOfWormWheelTooth == _calculationSpeedRotation.MaxNumberOfWormWheelTooth)
        {
            NumberOfWormWheelWeethUp.interactable = false;
        }
        else
        {
            NumberOfWormWheelWeethUp.interactable = true;
        }

        if (_calculationSpeedRotation.NumberOfWormWheelTooth == _calculationSpeedRotation.MinNumberOfWormWheelTooth)
        {
            NumberOfWormWheelWeethDown.interactable = false;
        }
        else
        {
            NumberOfWormWheelWeethDown.interactable = true;
        }
    }*/

   /* public void InteractableButtonsNumberWormVisit()
    {
        if (_calculationSpeedRotation.NumberWormVisit == _calculationSpeedRotation.MaxNumberWormVisit)
        {
            NumberWormVisitUp.interactable = false;
        }
        else 
        {
            NumberWormVisitUp.interactable = true;
        }
        if (_calculationSpeedRotation.NumberWormVisit == _calculationSpeedRotation.MinNumberWormVisit)
        {
            NumberWormVisitDown.interactable = false;
        }
        else
        {
            NumberWormVisitDown.interactable = true;
        }
    
    }*/
    public void IncreaseNumberOfWormWheelWeeth()
    {
        //_calculationSpeedRotation.NumberOfWormWheelTooth++;
        _calculationSpeedRotation.NumberOfWormWheelTooth = SliderWormWheel.value;
    }
   /* public void DecreaseNumberOfWormWheelWeeth()
    {
        _calculationSpeedRotation.NumberOfWormWheelTooth--;
    }*/
    public void IncreaseNumberWormVisit()
    {
        _calculationSpeedRotation.NumberWormVisit = SliderWorm.value;
        //_calculationSpeedRotation.NumberWormVisit++;
    }
   /* public void DecreaseNumberWormVisit()
    {
        _calculationSpeedRotation.NumberWormVisit--;
    }*/

    public void IncreaseSpeedWorm()
    {
        // _calculationSpeedRotation.SpeedWorm += 25f;
        _calculationSpeedRotation.SpeedWorm = SliderSpeedWorm.value;
    }
    /*public void DecreasSpeedWorm()
    {
        _calculationSpeedRotation.SpeedWorm -= 25f;
   }*/
 }
