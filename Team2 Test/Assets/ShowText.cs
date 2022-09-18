using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    [SerializeField] GameObject _textReplay;

    private void OnMouseOver()
    {
        FindObjectOfType<ShowText>()._textReplay.gameObject.GetComponent<GameObject>().SetActive(true);
    }
    private void OnMouseExit()
    {
        FindObjectOfType<ShowText>()._textReplay.gameObject.GetComponent<GameObject>().SetActive(false);
        
    }
}
