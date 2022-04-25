using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListShopView : MonoBehaviour
{
    public GameObject qbBox;
    public GameObject dqBox;
    public GameObject txBox;
    void Update()
    {
        if (DowndownLabel.ShopList == 0)
        {
            qbBox.SetActive(false);
            dqBox.SetActive(true);
            txBox.SetActive(false);
        }
        else if (DowndownLabel.ShopList == 1)
        {
            qbBox.SetActive(true);
            dqBox.SetActive(false);
            txBox.SetActive(false);
        }
        else if (DowndownLabel.ShopList == 2)
        {
            qbBox.SetActive(false);
            dqBox.SetActive(false);
            txBox.SetActive(true);
        }
        else if (DowndownLabel.ShopList == 3)
        {
            qbBox.SetActive(false);
            dqBox.SetActive(false);
            txBox.SetActive(false);
        }
    }
}
