using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Retote : MonoBehaviour
{
    public GameObject Title;
    void Start()
    {
        Title.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -4));
        for (; ; )
        {
            for (int i = 1; i <= 8; i *= 2)
            {
                Title.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, i));
                Thread.Sleep(199);
            }
            for (int i = 1; i <= 8; i *= 2)
            {
                Title.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -i));
                Thread.Sleep(199);

            }
        }
    }
}
