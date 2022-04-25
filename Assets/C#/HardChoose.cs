using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardChoose : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    public static int hard = 0;
    // Start is called before the first frame update
    void Start()
    {
        hard = 0;

    }
    private void Update()
    {
        if (Menu.Lanuage == 0)
        {
            if (hard == 0)
            {
                text.text = "难度选择:EZ";
            }
            else if (hard == 1)
            {
                text.text = "难度选择:HD";
            }
            else if (hard == 2)
            {
                text.text = "难度选择:GD";
            }
        }
        else if (Menu.Lanuage == 1)
        {
            if (hard == 0)
            {
                text.text = "難度選擇:EZ";
            }
            else if (hard == 1)
            {
                text.text = "難度選擇:HD";
            }
            else if (hard == 2)
            {
                text.text = "難度選擇:GD";
            }
        }
        else if (Menu.Lanuage == 2)
        {
            if (hard == 0)
            {
                text.text = "Difficulty Selection-EZ";
            }
            else if (hard == 1)
            {
                text.text = "Difficulty Selection-HD";
            }
            else if (hard == 2)
            {
                text.text = "Difficulty Selection-GD";
            }
        }
        else if (Menu.Lanuage == 3)
        {
            if (hard == 0)
            {
                text.text = "難易度の選択:EZ";
            }
            else if (hard == 1)
            {
                text.text = "難易度の選択:HD";
            }
            else if (hard == 2)
            {
                text.text = "難易度の選択:GD";
            }
        }
        else if (Menu.Lanuage == 4)
        {
            if (hard == 0)
            {
                text.text = "난이도 선택:EZ";
            }
            else if (hard == 1)
            {
                text.text = "난이도 선택:HD";
            }
            else if (hard == 2)
            {
                text.text = "난이도 선택:GD";
            }
        }
    }
    public void OnClick()
    {
        if (hard >= 2)
        {
            hard = 0;
        }
        else {
            hard++;
        }
    }
}
