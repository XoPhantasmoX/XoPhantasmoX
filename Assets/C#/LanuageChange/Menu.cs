using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public UnityEngine.UI.Text shop;
    public UnityEngine.UI.Text quit;
    public UnityEngine.UI.Text lanuage;
    public UnityEngine.UI.Text info;

    public static int Lanuage;
    /*
     *简体中文 = 0
     *繁体中文 = 1
     *    英语 = 2
     *    日语 = 3
     *    韩语 = 4
     */
     

    // Update is called once per frame
    void Update()
    {
        if (Lanuage == 0)//简体中文
        {
            shop.text = "商店";
            quit.text = "退出";
            lanuage.text = "切换语言";
            info.text = "WaveLoop内部版本";
        }
        else if (Lanuage == 1)//繁体中文
        {
            shop.text = "商店";
            quit.text = "終止";
            lanuage.text = "切換語言";
            info.text = "WaveLoop内部版本";
        }
        else if (Lanuage == 2)//英语
        {
            shop.text = "Shop";
            quit.text = "Quit";
            lanuage.text = "switch language";
            info.text = "WaveLoop Internal Measurement";
        }
        else if (Lanuage == 3)//日语
        {
            shop.text = "ストア";
            quit.text = "終了";
            lanuage.text = "言語切り替え";
            info.text = "WaveLoop 内部バージョン";

        }
        else if (Lanuage == 4)//韩语
        {
            shop.text = "상점";
            quit.text = "퇴장하다";
            lanuage.text = "전환 언어";
            info.text = "음몽회로 내부 버전";
        }
    }
}


/*_________        _________        _______   _____________
 * \       \      /         \      /      /  /             \    \     \        /     /
 *  \       \    /           \    /      /  /      /\       \    \     \      /     /
 *   \       \  /             \  /      /  /      /__\       \    \     \    /     /
 *    \       \/      /\       \/      /  /      ______       \    \     \  /     /
 *     \             /  \             /  /      /      \       \    \     \/     /
 *      \           /    \           /  /      /        \       \    \          /
 *       \_________/      \_________/  /______/          \_______\    \________/
 * 
 * 
 * 
 * 
 * 
 * 
 */
 
