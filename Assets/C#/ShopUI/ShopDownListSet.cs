using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopDownListSet : MonoBehaviour
{
    void Update()
    {
        if (GameObject.Find("Canvas/Dropdown/Dropdown List/Viewport/Content/Item 0: 单曲/Item Label").gameObject != null)
        {
            UnityEngine.UI.Text dq;
            dq = GameObject.Find("Canvas/Dropdown/Dropdown List/Viewport/Content/Item 0: 单曲/Item Label").GetComponent<UnityEngine.UI.Text>();
            UnityEngine.UI.Text qb;
            qb = GameObject.Find("Canvas/Dropdown/Dropdown List/Viewport/Content/Item 1: 曲包/Item Label").GetComponent<UnityEngine.UI.Text>();
            UnityEngine.UI.Text tx;
            tx = GameObject.Find("Canvas/Dropdown/Dropdown List/Viewport/Content/Item 2: 头像/Item Label").GetComponent<UnityEngine.UI.Text>();
            UnityEngine.UI.Text cj;
            cj = GameObject.Find("Canvas/Dropdown/Dropdown List/Viewport/Content/Item 3: 抽奖/Item Label").GetComponent<UnityEngine.UI.Text>();
            if (Menu.Lanuage == 0)
            {
                dq.text = "单曲";
                qb.text = "精选集";
                tx.text = "头像";
                cj.text = "抽奖";
            }
            else if (Menu.Lanuage == 1)
            {
                dq.text = "單曲";
                qb.text = "精選集";
                tx.text = "頭像";
                cj.text = "抽獎";
            }
            else if (Menu.Lanuage == 2)
            {
                dq.text = "Single";
                qb.text = "Chapter EX";
                tx.text = "Avatar";
                cj.text = "Lottery";
            }
            else if (Menu.Lanuage == 3)
            {
                dq.text = "シングル曲";
                qb.text = "選り抜き集";
                tx.text = "アイコン";
                cj.text = "くじを引く";
            }
            else if (Menu.Lanuage == 4)
            {
                dq.text = "싱글";
                qb.text = "정선집";
                tx.text = "두상";
                cj.text = "추첨하다";
            }
        }
        else
        {
            Debug.LogWarning("找不到对应文件（测试）");
        }
    }
}
