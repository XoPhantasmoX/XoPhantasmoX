using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KR : MonoBehaviour
{
    public void Onclick()
    {
        Menu.Lanuage = 4;
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("LanuageSitting",4);

    }
}
