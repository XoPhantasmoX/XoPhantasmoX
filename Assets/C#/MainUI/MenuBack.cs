using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBack : MonoBehaviour
{
    public GameObject menuList;
    public void hideMenu()
    {
        menuList.SetActive(false);
    }
}
