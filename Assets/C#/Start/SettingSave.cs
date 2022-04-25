using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingSave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Menu.Lanuage = PlayerPrefs.GetInt("LanuageSitting");
        if (PlayerPrefs.GetString("UserName").Equals(""))
        {
            HideBox.Name = "Player";
        }
        else
        {
            HideBox.Name = PlayerPrefs.GetString("UserName");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
