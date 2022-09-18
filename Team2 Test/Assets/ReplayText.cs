using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayText : MonoBehaviour
{
    [SerializeField] Text _replayText;

    private void OnMouseEnter()
    {
        _replayText.enabled = true;
    }
}
