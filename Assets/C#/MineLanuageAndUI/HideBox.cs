using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBox : MonoBehaviour
{
    public static string Name;
    public UnityEngine.UI.Text GetText;
    public void OnClick()
    {
        HideBoxCenter.mineHide = false;
        Name = GetText.text;
        PlayerPrefs.SetString("UserName", GetText.text);
    }
}
