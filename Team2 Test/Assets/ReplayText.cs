using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ReplayText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameObject _replayText;

    

    public void OnPointerExit(PointerEventData eventData)
    {
        _replayText.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _replayText.SetActive(true);
    }
}
