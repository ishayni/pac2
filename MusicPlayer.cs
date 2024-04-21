using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicPlayer : MonoBehaviour
{
    public bool audios;
    public TextMeshProUGUI textMesh;
    public AudioClip[] clips;
    private AudioSource audioSource;
    // Start is called before the first frame update
    public void OnMusic()
    {
        audioSource.Play();
        audios = false;
    }
    public void OffMusic()
    {
        audios = true;
        audioSource.Pause();
    }
    public void cambiar()
    {
        var oldaudio = audioSource.clip;
        audioSource.clip = GetRandomClip();
        if (audioSource.clip == oldaudio ) {
            cambiar();
        }else
        {
            audioSource.Play();
        }
        
    }
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
        audios = true;
    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }

    // Update is called once per frame
    void Update()
    {
       if (audios == false)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = GetRandomClip();
                audioSource.Play();
            }
        }
        

    }

}
