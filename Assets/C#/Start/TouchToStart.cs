using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchToStart : MonoBehaviour
{
    public GameObject ChV;
    public GameObject EnV;
    // Start is called before the first frame update
    void Start()
    {
        if (Menu.Lanuage == 0)
        {
            ChV.SetActive(true);
            EnV.SetActive(false);
        }
        else
        {
            ChV.SetActive(false);
            EnV.SetActive(true);
        }
        Thread.Sleep(3000);
        ChV.SetActive(false);
        EnV.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
