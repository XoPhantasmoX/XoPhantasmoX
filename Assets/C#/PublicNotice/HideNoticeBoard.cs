using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideNoticeBoard : MonoBehaviour
{
    public GameObject Board;
    public void Onclick() {
        Board.SetActive(false);
    }
}
