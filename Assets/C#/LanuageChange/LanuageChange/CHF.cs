using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHF : MonoBehaviour
{
    public void Onclick()
    {
        Menu.Lanuage = 1;
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("LanuageSitting", 1);
    }
}
