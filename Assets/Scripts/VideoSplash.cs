using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoSplash : MonoBehaviour
{
    VideoPlayer vPlayer;

    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();
        // Video bittiğinde çalışacak fonksiyonu tanımlıyoruz
        vPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
        // "MainMenu" senin ana menü sahnenin adı olmalı
        SceneManager.LoadScene("MainMenu");
    }
}