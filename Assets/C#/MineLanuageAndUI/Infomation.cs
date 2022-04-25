using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infomation : MonoBehaviour
{

    public UnityEngine.UI.Text level;
    public UnityEngine.UI.Text UserName;
    string PerfixUserName;
    private void Update()
    {

        if (Menu.Lanuage == 0)
        {
            PerfixUserName = "您的游戏昵称: ";
        }
        else if (Menu.Lanuage == 1)
        {
            PerfixUserName = "您的遊戲昵稱: ";
        }
        else if (Menu.Lanuage == 2)
        {
            PerfixUserName = "Your Game ID: ";
        }
        else if (Menu.Lanuage == 3)
        {
            PerfixUserName = "ニックネーム: ";
        }
        else if (Menu.Lanuage == 4)
        {
            PerfixUserName = "게임 닉네임: ";
        }
        UserName.text = (PerfixUserName + HideBox.Name);
    }
}
