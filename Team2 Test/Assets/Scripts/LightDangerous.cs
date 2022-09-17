using UnityEngine;

public class LightDangerous : MonoBehaviour
{
    public int _status;
    Renderer _renderer;
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        if (_status == 0)
        {
            _renderer.material.EnableKeyword("_EMISSION");
            _renderer.material.color = Color.white;
            _renderer.material.SetColor("_EmissionColor", Color.white * 9);
        }
        if (_status == 1)
        {
            _renderer.material.EnableKeyword("_EMISSION");
            _renderer.material.color = Color.yellow;
            _renderer.material.SetColor("_EmissionColor", Color.yellow * 9);
        }
        if (_status == 2)
        {
            _renderer.material.EnableKeyword("_EMISSION");
            _renderer.material.color = Color.red;
            _renderer.material.SetColor("_EmissionColor", Color.red * 9);
        }
        if (_status == 3)
        {
            _renderer.material.DisableKeyword("_EMISSION");
            _renderer.material.SetColor("_EmissionColor", Color.red * 9);
        }
    }
}
