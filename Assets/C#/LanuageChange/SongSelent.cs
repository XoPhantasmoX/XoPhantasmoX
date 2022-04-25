using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SongSelent : MonoBehaviour
{
    public UnityEngine.UI.Text start;
    public UnityEngine.UI.Text back;
    internal int itemIndex;

    void Update()
    {
        if (Menu.Lanuage == 0)
        {
            start.text = "开始";
            back.text = "返回";
        }
        else if (Menu.Lanuage == 1)
        {
            start.text = "開始";
            back.text = "返回";
        }
        else if (Menu.Lanuage == 2)
        {
            start.text = "Start";
            back.text = "Back";
        }
        else if (Menu.Lanuage == 3)
        {
            start.text = "スタート";
            back.text = "戻る";
        }
    }
}
