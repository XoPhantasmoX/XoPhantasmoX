using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Globe
{
    public static string nextSceneName;
}

public class AsyncLoadScene : MonoBehaviour
{
    public Text loadingText;

    private int curProgressValue = 0;

    private AsyncOperation operation;
    
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Loading")
        {
            StartCoroutine(AsyncLoading());
        }
    }

    IEnumerator AsyncLoading()
    {
        operation = SceneManager.LoadSceneAsync(Globe.nextSceneName);
        operation.allowSceneActivation = false;

        yield return operation;
    }
    
    void Update()
    {

        int progressValue = 100;

        if (curProgressValue < progressValue)
        {
            curProgressValue++;
        }

        loadingText.text = "Loading"+curProgressValue + "%";

        if (curProgressValue == 100)
        {
            SceneManager.LoadScene(Globe.nextSceneName);
            loadingText.text = "Complete!";
            operation.allowSceneActivation = true;

        }
    }
}