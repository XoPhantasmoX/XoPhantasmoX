using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterMove : MonoBehaviour
{
    public List<GameObject> cellsRight;
    public bool switchM;
    public List<Celll> cellsRightNows = new List<Celll>();
    public List<Celll> cellsLeftNows = new List<Celll>();
    void Start()
    {
        StartCoroutine(Wait());
    }
    public IEnumerator Wait()
    {
        yield return 0;
        GameObject content = GameObject.Find("Content");//����cellλ��Content֮�£���cell���ְ���һ��ͼƬ��һ�����ֿ�
        Transform[] allTrans = content.gameObject.GetComponentsInChildren<Transform>(true);//��Content�µ������������������Ž�����
        for (int i = 0; i < allTrans.Length; i++)
        {
            if (allTrans[i].gameObject.name == "Image" && allTrans[i].gameObject.GetComponent<RectTransform>().anchorMax.x > 0.5f)
            {//�ж������е���������������Ƿ�ΪͼƬ��ͼƬ�Ƿ�λ����Ļ�Ҳ�
                cellsRight.Add(allTrans[i].gameObject.transform.parent.gameObject);//��ͼƬ�ĸ����壨��cell��Ԫ��)����cellsRight
            }
        }
        for (int m = 0; m <= cellsRight.Count - 1; m++)
        {
            cellsRight[m].transform.SetAsFirstSibling();
        }
        switchM = true;
    }

    void Update()
    {
        GameObject content = GameObject.Find("Content");
        if (switchM == true)
        {
            cellsRightNows.Clear();
            cellsLeftNows.Clear();
            Transform[] allTrans = content.gameObject.GetComponentsInChildren<Transform>(true);//��Content�µ������������������Ž�����
            for (int i = 0; i < allTrans.Length; i++)
            {
                if (allTrans[i].gameObject.name == "Image" && allTrans[i].gameObject.GetComponent<RectTransform>().anchorMax.x > 0.5f)
                {//�ж������е���������������Ƿ�ΪͼƬ��ͼƬ�Ƿ�λ����Ļ�Ҳ�
                    cellsRightNows.Add(new Celll(allTrans[i].gameObject.transform.parent.gameObject, allTrans[i].gameObject.GetComponent<RectTransform>().anchorMax.x));
                    //cellsRightNow.Add(allTrans[i].gameObject.transform.parent.gameObject);
                }
                else if (allTrans[i].gameObject.name == "Image" && allTrans[i].gameObject.GetComponent<RectTransform>().anchorMax.x < 0.5f)
                {//�ж������е���������������Ƿ�ΪͼƬ��ͼƬ�Ƿ�λ����Ļ���
                    cellsLeftNows.Add(new Celll(allTrans[i].gameObject.transform.parent.gameObject, allTrans[i].gameObject.GetComponent<RectTransform>().anchorMax.x));
                    //cellsLeftNow.Add(allTrans[i].gameObject.transform.parent.gameObject);
                }

            }
            if (cellsRight.Count != cellsRightNows.Count)//˵������
            {
                Debug.Log("������");
                cellsRightNows.Sort(delegate (Celll x, Celll y)
                {
                    return x.Celllsx.CompareTo(y.Celllsx);
                });
                cellsLeftNows.Sort(delegate (Celll x, Celll y)
                {
                    return x.Celllsx.CompareTo(y.Celllsx);
                });
                for (int n = 0; n <= cellsLeftNows.Count - 1; n++)
                {
                    cellsLeftNows[n].Cellls.transform.SetAsLastSibling();
                }
                for (int n = 0; n <= cellsRightNows.Count - 1; n++)
                {
                    cellsRightNows[n].Cellls.transform.SetAsFirstSibling();
                }
                cellsRight.Clear();
                //cellsRight.AddRange(cellsRightNow);
                for (int n = 0; n <= cellsRightNows.Count - 1; n++)
                {
                    cellsRight.Add(cellsRightNows[n].Cellls);
                }
            }

        }
    }
}
public class Celll
{
    public GameObject Cellls { get; set; }
    public float Celllsx { get; set; }
    public Celll(GameObject cellls, float celllsx)
    {
        Cellls = cellls;
        Celllsx = celllsx;
    }

}