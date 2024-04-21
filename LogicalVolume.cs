using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicalVolume : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image ImagenMute;
    
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = sliderValue;
        RevisarSiEstoyMute();
    }
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = sliderValue;
        RevisarSiEstoyMute();
    }
    public void RevisarSiEstoyMute()
    {
        if (sliderValue == 0)
        {
            ImagenMute.enabled = true;
        } else
        {
            ImagenMute.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
