using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSound : MonoBehaviour
{
    public static ControlSound Instance;
    private AudioSource audioSource;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
        audioSource = GetComponent<AudioSource>();
    }

    public void ejectSound(AudioClip sound) {
        audioSource.PlayOneShot(sound);
    }
}
