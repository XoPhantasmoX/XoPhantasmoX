using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SinceChange : MonoBehaviour
{
    public void SinceChangeMain(string sinceName) {

        Globe.nextSceneName = sinceName;
        SceneManager.LoadScene("LoadingScene");
    }
}
