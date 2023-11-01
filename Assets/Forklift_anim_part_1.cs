using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Forklift_anim_part_1 : MonoBehaviour
{
    public Animator animator;
    public float stopTime;

    public AudioMixer audioMixer;
    public AudioSource audioSource3;
    public AudioClip audioClip3;

    public void whenButtonClicked()
    {
        GetComponent<Animator>().Play("Forklift_anim_withBox");
        Invoke("StopAnimation", stopTime);
    }

    private void StopAnimation()
    {
        GetComponent<Animator>().enabled = false;
        audioSource3.clip = audioClip3;
        audioSource3.outputAudioMixerGroup = audioMixer.outputAudioMixerGroup;
        audioSource3.Play();
    }
}
