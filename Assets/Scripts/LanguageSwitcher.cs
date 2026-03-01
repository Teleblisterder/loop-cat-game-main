using UnityEngine;

public class LanguageSwitcher : MonoBehaviour
{
    [Header("Dil TR olunca gizlenecek obje")]
    public GameObject ingilizceAltyaziObjesi; 

    public void TurkceYap()
    {
        LocalizationManager.Instance.ChangeLanguage("TR");
        
        // Dil Türkçe olunca İngilizce altyazıyı kapat
        if (ingilizceAltyaziObjesi != null)
        {
            ingilizceAltyaziObjesi.SetActive(false);
        }
    }

    public void IngilizceYap()
    {
        LocalizationManager.Instance.ChangeLanguage("EN");
        
        // Dil İngilizce olunca İngilizce altyazıyı tekrar aç
        if (ingilizceAltyaziObjesi != null)
        {
            ingilizceAltyaziObjesi.SetActive(true);
        }
    }
}