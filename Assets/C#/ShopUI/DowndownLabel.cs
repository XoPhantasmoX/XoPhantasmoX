using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DowndownLabel : MonoBehaviour
{
    public UnityEngine.UI.Text label;
    public static int ShopList;
    void Update()
    {
        if (Menu.Lanuage == 0)
        {
            if (label.text.Equals("单曲"))
            {
                label.text = "单曲";
                ShopList = 0;
            }
            else if (label.text.Equals("曲包"))
            {
                label.text = "精选集";
                ShopList = 1;
            }
            else if (label.text.Equals("头像"))
            {
                label.text = "头像";
                ShopList = 2;
            }
            else if (label.text.Equals("抽奖"))
            {
                label.text = "抽奖";
                ShopList = 3;
            }
        }
        if (Menu.Lanuage == 1)
        {
            if (label.text.Equals("单曲"))
            {
                label.text = "單曲";
                ShopList = 0;
            }
            else if (label.text.Equals("曲包"))
            {
                label.text = "精選集";
                ShopList = 1;
            }
            else if (label.text.Equals("头像"))
            {
                label.text = "頭像";
                ShopList = 2;
            }
            else if (label.text.Equals("抽奖"))
            {
                label.text = "抽獎";
                ShopList = 3;
            }
        }
        else if (Menu.Lanuage == 2)
        {
            if (label.text.Equals("单曲"))
            {
                label.text = "Single";
                ShopList = 0;
            }
            else if (label.text.Equals("曲包"))
            {
                label.text = "Chapter EX";
                ShopList = 1;
            }
            else if (label.text.Equals("头像"))
            {
                label.text = "Avatar";
                ShopList = 2;
            }
            else if (label.text.Equals("抽奖"))
            {
                label.text = "Lottery";
                ShopList = 3;
            }
        }
        else if (Menu.Lanuage == 3)
        {
            if (label.text.Equals("单曲"))
            {
                label.text = "シングル曲";
                ShopList = 0;
            }
            else if (label.text.Equals("曲包"))
            {
                label.text = "選り抜き集";
                ShopList = 1;
            }
            else if (label.text.Equals("头像"))
            {
                label.text = "アイコン";
                ShopList = 2;
            }
            else if (label.text.Equals("抽奖"))
            {
                label.text = "くじを引く";
                ShopList = 3;
            }
        }
        else if (Menu.Lanuage == 4)
        {
            if (label.text.Equals("单曲"))
            {
                label.text = "싱글";
                ShopList = 0;
            }
            else if (label.text.Equals("曲包"))
            {
                label.text = "정선집";
                ShopList = 1;
            }
            else if (label.text.Equals("头像"))
            {
                label.text = "두상";
                ShopList = 2;
            }
            else if (label.text.Equals("抽奖"))
            {
                label.text = "추첨하다";
                ShopList = 3;
            }
        }
    }
}
