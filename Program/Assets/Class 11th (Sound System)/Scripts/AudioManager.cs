using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{    
    [SerializeField] AudioSource audioSource;
    
    private static AudioManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public static void Listen(AudioClip audioClip)
    {        
        instance.audioSource.PlayOneShot(audioClip);
    }
}
