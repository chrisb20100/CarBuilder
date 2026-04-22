using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource engineAudio;

    public void PlayEngine()
    {
        if (!engineAudio.isPlaying)
            engineAudio.Play();
    }

    public void StopEngine()
    {
        if (engineAudio.isPlaying)
            engineAudio.Stop();
    }
}
