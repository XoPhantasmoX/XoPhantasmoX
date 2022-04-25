using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOut : MonoBehaviour
{
    private void Start()
    {
        menuList.SetActive(true);
        menuList.SetActive(false);
    }
    public GameObject menuList;
    public void ActiveMenu()
    {
        menuList.SetActive(true);
    }
}
