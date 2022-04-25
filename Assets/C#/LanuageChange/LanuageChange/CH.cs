using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH : MonoBehaviour
{
    public void Onclick()
    {
        Menu.Lanuage = 0;
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.SetInt("LanuageSitting", 0);
    }
}
