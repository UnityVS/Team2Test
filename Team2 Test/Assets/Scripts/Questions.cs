using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Questions : MonoBehaviour
{
    [SerializeField] List<TextMeshProUGUI> _textNarrativ;
    int _narrativID = 0;
    [SerializeField] List<TextMeshProUGUI> _missions;
    int _missionID = 0;
    [SerializeField] GameObject _gameObjectNarrativ;
    [SerializeField] GameObject _gameObjectNarrativBackground;
    [SerializeField] TextMeshProUGUI _buttonStart;
    [SerializeField] TextMeshProUGUI _textSuccess;
    [SerializeField] TextMeshProUGUI _textFail;
    CalculationSpeedRotation _calculationSpeedRotation;
    int _tutorial = 0;
    List<int> _exitPower = new List<int>() { 2700, 30000, 25000, 0 };
    void Start()
    {
        _narrativID = PlayerPrefs.GetInt(nameof(_narrativID));
        _missionID = PlayerPrefs.GetInt(nameof(_missionID));
        _tutorial = PlayerPrefs.GetInt(nameof(_tutorial));
        _calculationSpeedRotation = FindObjectOfType<CalculationSpeedRotation>();
        if (PlayerPrefs.GetInt(nameof(_narrativID)) == _textNarrativ.Count)
        {
            if (PlayerPrefs.GetInt(nameof(_missionID)) == _missions.Count)
            {
                FullCloseMissions();
            }
            else
            {
                CloseTutorial();
                _gameObjectNarrativ.SetActive(true);
                _missions[PlayerPrefs.GetInt(nameof(_missionID))].gameObject.SetActive(true);
            }
        }
        else if (PlayerPrefs.GetInt(nameof(_narrativID)) != _textNarrativ.Count)
        {
            PlayerPrefs.SetInt(nameof(_narrativID), 0);
            _gameObjectNarrativBackground.SetActive(true);
            _gameObjectNarrativ.SetActive(true);
            _textNarrativ[PlayerPrefs.GetInt(nameof(_narrativID))].gameObject.SetActive(true);
        }
    }
    public void NarrativFlow()
    {
        if (_tutorial == 0)
        {
            _textNarrativ[_narrativID].gameObject.SetActive(false);
            _narrativID++;
            if (_narrativID == _textNarrativ.Count - 1)
            {
                _buttonStart.text = "Начать!";
            }
            if (_narrativID == _textNarrativ.Count)
            {
                CloseTutorial();
                _buttonStart.text = "Проверить";
                PlayerPrefs.SetInt(nameof(_narrativID), _textNarrativ.Count);
                _tutorial++;
                PlayerPrefs.SetInt(nameof(_tutorial), _tutorial);
                _missions[_missionID].gameObject.SetActive(true);
                return;
            }
            _textNarrativ[_narrativID].gameObject.SetActive(true);
        }
        else if (_tutorial == 1)
        {
            MissionsFlow();
        }
    }
    public void MissionsFlow()
    {
        if (_textFail.gameObject.activeSelf || _textSuccess.gameObject.activeSelf)
        {
            _textFail.gameObject.SetActive(false);
            _textSuccess.gameObject.SetActive(false);
        }
        if (_exitPower.Count != _missionID && _exitPower[_missionID] > _calculationSpeedRotation.SpeedWormWheel * 9.4f && _exitPower[_missionID] < _calculationSpeedRotation.SpeedWormWheel * 9.6f || _exitPower.Count == _missionID+1 && _calculationSpeedRotation.SpeedWormWheel * 9.4f == _exitPower[_missionID])
        {
            _missions[_missionID].gameObject.SetActive(false);
            _missionID++;
            PlayerPrefs.SetInt(nameof(_missionID), _missionID);
            if (_missionID == _missions.Count - 1)
            {
                _buttonStart.text = "Завершить!";
            }
            if (_missionID == _missions.Count)
            {
                FullCloseMissions();
                PlayerPrefs.SetInt(nameof(_missionID), _missions.Count);
                return;
            }
            _textSuccess.gameObject.SetActive(true);
            _missions[_missionID].gameObject.SetActive(true);
        }
        else
        {
            _textFail.gameObject.SetActive(true);
        }
    }
    void CloseTutorial()
    {
        //_gameObjectNarrativ.SetActive(false);
        _gameObjectNarrativBackground.SetActive(false);
    }
    void FullCloseMissions()
    {
        _gameObjectNarrativ.SetActive(false);
        _gameObjectNarrativBackground.SetActive(false);
    }
    public void TutorialPlayAgain()
    {
        PlayerPrefs.SetInt(nameof(_tutorial), 0);
        PlayerPrefs.SetInt(nameof(_missionID), 0);
        PlayerPrefs.SetInt(nameof(_narrativID), 0);
        SceneManager.LoadScene(1);
    }
}
