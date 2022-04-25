using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        PlayerPrefs.SetInt("newPlayer", 1);
        EditorApplication.isPlaying = false;
#else
        PlayerPrefs.SetInt("newPlayer", 1);
        Application.Quit();
        
#endif
    }
}
