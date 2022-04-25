using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EN : MonoBehaviour
{
    public void Onclick()
    {
        Menu.Lanuage = 2;
        SceneManager.LoadScene("SampleScene");

        PlayerPrefs.SetInt("LanuageSitting", 2);
    }
}
