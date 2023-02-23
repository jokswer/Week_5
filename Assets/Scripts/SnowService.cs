using UnityEngine;

public class SnowService : MonoBehaviour
{
    [SerializeField] private ParticleSystem _snow;

    public void ToggleSnow(bool value)
    {
        if (value)
        {
            _snow.Play();
        }
        else
        {
            _snow.Stop();
        }
    }
}