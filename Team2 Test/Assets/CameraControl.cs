using UnityEngine;

public class CameraControl : MonoBehaviour
{

    [SerializeField] Camera _cameraIsOne;
    [SerializeField] Camera _cameraIsTwo;
    [SerializeField] Camera _cameraIsThree;

    public void CameraIsOne()
    {
        FindObjectOfType<CameraControl>()._cameraIsOne.GetComponent<Camera>().enabled = true;
        FindObjectOfType<CameraControl>()._cameraIsTwo.GetComponent<Camera>().enabled = false;
        FindObjectOfType<CameraControl>()._cameraIsThree.GetComponent<Camera>().enabled = false;
    }
    public void CameraIsTwo()
    {
        FindObjectOfType<CameraControl>()._cameraIsOne.GetComponent<Camera>().enabled = false;
        FindObjectOfType<CameraControl>()._cameraIsTwo.GetComponent<Camera>().enabled = true;
        FindObjectOfType<CameraControl>()._cameraIsThree.GetComponent<Camera>().enabled = false;
    }
    public void CameraIsThree()
    {
        FindObjectOfType<CameraControl>()._cameraIsOne.GetComponent<Camera>().enabled = false;
        FindObjectOfType<CameraControl>()._cameraIsTwo.GetComponent<Camera>().enabled = false;
        FindObjectOfType<CameraControl>()._cameraIsThree.GetComponent<Camera>().enabled = true;

    }
}
