using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; // Audio Mixer

public class audio_script : MonoBehaviour
{
    public AudioMixer audioMixer; // Create/Select Audio Mixer from Window/Audio/Audio Mixer
    public AudioSource audioSource1;
    public AudioClip audioClip1;
    public AudioSource audioSource2;
    public AudioClip audioClip2;
    public float pauseTime;

    public void PlayAudio1()
    {
        audioSource1.clip = audioClip1;
        audioSource1.outputAudioMixerGroup = audioMixer.outputAudioMixerGroup;
        audioSource1.Play();
    }

    public void PlayAudio2()
    {
        audioSource2.clip = audioClip2;
        audioSource2.outputAudioMixerGroup = audioMixer.outputAudioMixerGroup;
        audioSource2.Play();
        StartCoroutine(PauseAudio2());
    }

    IEnumerator PauseAudio2()
    {
        yield return new WaitForSeconds(pauseTime);
        audioSource2.Pause();
    }
}
