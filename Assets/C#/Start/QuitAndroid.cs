using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitAndroid : MonoBehaviour
{
    private int mPressTimes = 0;
    void Start()
    {
        //Ensure that there is only one gameQuit in the Scene����ʹ�������¸�����Scene
        GameObject[] gameQuits = GameObject.FindGameObjectsWithTag("GameQuit");
        if (gameQuits.Length == 2)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {//KeyCode.Escape��ʾ����ESC,�ֻ��ķ��ؼ�
            mPressTimes++;
            StartCoroutine("ResetMPressTimes", 1.0f);//������1�붼û�а���2��������mPressTimes
            if (mPressTimes == 2)
            {
                Application.Quit();
            }
        }
    }

    IEnumerator ResetMPressTimes(float sec)
    {
        yield return new WaitForSeconds(sec);
        mPressTimes = 0;
    }
}
