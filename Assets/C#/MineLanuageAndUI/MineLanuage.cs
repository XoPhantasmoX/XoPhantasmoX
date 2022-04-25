using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineLanuage : MonoBehaviour
{
    public UnityEngine.UI.Text Change;
    public UnityEngine.UI.Text OK;

    // Update is called once per frame
    void Update()
    {
        if (Menu.Lanuage == 0) {
            Change.text ="修改信息";
            OK.text = "确定";
        }
        else if (Menu.Lanuage == 1)
        {
            Change.text = "修改信息";
            OK.text = "確定";
        }
        else if (Menu.Lanuage == 2)
        {
            Change.text = "Modify information";
            OK.text = "OK";
        }
        else if (Menu.Lanuage == 3)
        {
            Change.text = "情報の変更";
            OK.text = "OK";
        }
        else if (Menu.Lanuage == 4)
        {
            Change.text = "정보 수정";
            OK.text = "확정하다";
        }
    }
}
