using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager _instance;
    private AudioSource audioSource;
    public AudioClip cSound, kSound, uSound, bSound, zSound, chSound, congratsSound;
    //public List<AudioClip> allSounds = new List<AudioClip>();

    private void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void cSoundPlay()
    {
        audioSource.PlayOneShot(cSound);
    }

    public void kSoundPlay()
    {
        audioSource.PlayOneShot(kSound);
    }

    public void uSoundPlay()
    {
        audioSource.PlayOneShot(uSound);
    }

    public void bSoundPlay()
    {
        audioSource.PlayOneShot(bSound);
    }

    public void zSoundPlay()
    {
        audioSource.PlayOneShot(zSound);
    }

    public void chSoundPlay()
    {
        audioSource.PlayOneShot(chSound);
    }


    public void CongratulationsSoundPlay()
    {
        audioSource.PlayOneShot(congratsSound);
    }
}
