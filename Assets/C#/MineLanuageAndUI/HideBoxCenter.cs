using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBoxCenter : MonoBehaviour
{
    public static bool mineHide;
    public GameObject Box;
    public GameObject InputText;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        mineHide = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mineHide == true)
        {
            Box.SetActive(true);
            InputText.SetActive(true);
            Button.SetActive(true);
        }
        else if (mineHide == false)
        {
            Box.SetActive(false);
            InputText.SetActive(false);
            Button.SetActive(false);
        }
    }
}
