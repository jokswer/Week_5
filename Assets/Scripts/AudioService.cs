using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioService : MonoBehaviour
{
    private AudioSource _audioSource;
    
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void TogglePlaying(bool value)
    {
        if (value)
        {
            _audioSource.Play();
        }
        else
        {
            _audioSource.Pause();
        }
    }
}