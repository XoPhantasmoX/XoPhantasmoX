using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicNoticeLanuage : MonoBehaviour
{
    private const string Key = "sb";
    public GameObject CN;
    public GameObject EN;
    public GameObject JP;
    public GameObject TW;
    public UnityEngine.UI.Text Title;
    public UnityEngine.UI.Text OK;
    public static int newPlayer;
    public GameObject Board;

    void Start()
    {
        newPlayer = PlayerPrefs.GetInt("newPlayer");
        if ((newPlayer == 0)|(newPlayer == 1))
        {
            PlayerPrefs.SetInt("newPlayer", 2);
            if (Menu.Lanuage == 0)
            {
                CN.SetActive(true);
                EN.SetActive(false);
                JP.SetActive(false);
                TW.SetActive(false);
                Title.text = "������";
                OK.text = "ȷ��";
            }
            else if (Menu.Lanuage == 1)
            {
                CN.SetActive(false);
                EN.SetActive(false);
                JP.SetActive(false);
                TW.SetActive(true);
                Title.text = "�����";
                OK.text = "�_��";
            }
            else if (Menu.Lanuage == 2)
            {
                CN.SetActive(false);
                EN.SetActive(true);
                JP.SetActive(false);
                TW.SetActive(false);
                Title.text = "Bulletin board";
                Title.text = "OK";
            }
            else if (Menu.Lanuage == 3)
            {
                CN.SetActive(false);
                EN.SetActive(false);
                JP.SetActive(true);
                TW.SetActive(false);
                Title.text = "��ʾ��";
                Title.text = "�狼�ä���";
            }
        }
        else
        {
            Board.SetActive(false);
        }

    }
}
