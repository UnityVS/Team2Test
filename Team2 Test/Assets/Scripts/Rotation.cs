using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Rigidbody Worm;

    private void Update()
    {
        Worm.AddRelativeTorque(Vector3.up, ForceMode.Impulse);
    }
}
