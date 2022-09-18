using UnityEngine;

public class AddCargo : MonoBehaviour
{
    public GameObject CubePref;
    public GameObject SpherePref;
    public GameObject CapsulePref;
    public GameObject CilinderPref;

    [SerializeField] GameObject _narative;

    public void CreateCargo()
    {
        Vector3 Rand = new Vector3(0, 0, Random.Range(-5, -10));
        if (Random.Range(1, 4) == 1)
        {
            Instantiate(CubePref, transform.position+ Rand, Quaternion.identity);
        }
        else if (Random.Range(1, 4) == 2)
        {
            Instantiate(SpherePref, transform.position + Rand, transform.rotation);
        }
        else if (Random.Range(1, 4) == 3)
        {
            Instantiate(CapsulePref, transform.position + Rand, transform.rotation);
        }
        else if (Random.Range(1, 4) == 4)
        {
            Instantiate(CilinderPref, transform.position + Rand, transform.rotation);
        }
    }
    public void ExitWindow()
    {
        _narative.gameObject.SetActive(false);
    }
}
