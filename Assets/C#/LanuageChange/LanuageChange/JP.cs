using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JP : MonoBehaviour
{
    public void Onclick()
    {
        Menu.Lanuage = 3;
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("LanuageSitting", 3);
    }
}
