using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffMusic : MonoBehaviour
{
    [SerializeField] AudioSource music;

    public void OnMusic() {

        music.Play();
    }
    public void OffMusic()
    {

        music.Stop();
    }

}
