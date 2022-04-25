using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public void OnBtnClick(string Scene)
    {
        Globe.nextSceneName = Scene;
        SceneManager.LoadScene("LoadingScene");
    }
}
