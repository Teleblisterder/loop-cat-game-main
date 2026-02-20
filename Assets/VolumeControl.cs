using UnityEngine;
using UnityEngine.Audio; // Mixer için gerekli
using UnityEngine.UI;    // Slider için gerekli

public class VolumeControl : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    void Start()
    {
        // Slider'ýn baþlangýç deðerini mevcut ses seviyesine eþitleyelim
        float value;
        mixer.GetFloat("MyExposedVolume", out value);
        slider.value = value;

        // Slider deðiþtikçe fonksiyonu çaðýr
        slider.onValueChanged.AddListener(SetLevel);
    }

    public void SetLevel(float sliderValue)
    {
        // Mixer'daki parametreyi günceller
        mixer.SetFloat("MyExposedVolume", sliderValue);
    }
}