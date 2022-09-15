using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunRoad : MonoBehaviour
{
    public List<Rigidbody> RoadRunPiece = new List<Rigidbody>();
    public GameObject RoadRunPiecePref;
    private CalculationSpeedRotation _calculationSpeedRotation;
    private RotationRigi RotationRigi;

    private void Start()
    {
        _calculationSpeedRotation = FindObjectOfType<CalculationSpeedRotation>();
        RotationRigi = FindObjectOfType<RotationRigi>();

        for (int i = 0; i < 30; i++)
        {
            GameObject newPieceRoadRun = Instantiate(RoadRunPiecePref, transform.position + new Vector3(i + 0.2f, 0, 0), transform.rotation);
            newPieceRoadRun.GetComponent<Rigidbody>().maxAngularVelocity = Mathf.Infinity;
            RoadRunPiece.Add(newPieceRoadRun.GetComponent<Rigidbody>());
        }
    }

    private void Update()
    {
        for (int i = 0; i < RoadRunPiece.Count; i++)
        {
            RoadRunPiece[i].angularVelocity = transform.up * _calculationSpeedRotation.SpeedWormWheel * Time.fixedDeltaTime*RotationRigi.DirectionValue;
        }
    }
}
