using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Audio_M : MonoBehaviour
{
    [SerializeField]
    private AudioSource m_Source;
    public void PlayAudio(AudioClip clip)
    {
        m_Source.clip = clip;
        m_Source.Play();
    }
}
