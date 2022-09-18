using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoText : MonoBehaviour
{
    [SerializeField] GameObject _firstText;
    [SerializeField] GameObject _infoText;

    private void OnMouseOver()
    {
        _firstText.SetActive(false);
        _infoText.SetActive(true);
    }
    private void OnMouseExit()
    {
        _firstText.SetActive(true);
        _infoText.SetActive(false);
    }
}
