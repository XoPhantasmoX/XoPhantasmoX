using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class StartChange : MonoBehaviour
{
    public VideoPlayer vPlayer;
    void Start()
    {
        vPlayer.loopPointReached += EndReached;
        vPlayer.Play();
    }

    void EndReached(VideoPlayer vPlayer)
    {
        SceneManager.LoadScene("Start");
    }   
    
}
