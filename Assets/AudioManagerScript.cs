using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    // Start is called before the first frame update

    [SerializeField] AudioSource sfxSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip die;
    public AudioClip point;
    public AudioClip hit;
    public AudioClip wing;
    public AudioClip swosh;

    public void playSFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
