using UnityEngine;
using UnityEngine.Audio; // Mixer için gerekli
using UnityEngine.UI;    // Slider için gerekli

public class VolumeControl : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    private string volumeParam = "MyExposedVolume";
    void Start()
    {
        

        // 2. Mevcut dB deðerini al ve Slider'ýn anlayacaðý 0-1 arasýna çevir
        float currentDB;
        if (mixer.GetFloat(volumeParam, out currentDB))
        {
            // dB'den lineer (0-1) deðere ters dönüþüm: 10^(dB/20)
            slider.value = Mathf.Pow(10, currentDB / 20);
        }

        slider.onValueChanged.AddListener(SetLevel);
    }

    public void SetLevel(float sliderValue)
    {
        float dB = Mathf.Log10(sliderValue) * 20;
        mixer.SetFloat(volumeParam, dB);
    }
}