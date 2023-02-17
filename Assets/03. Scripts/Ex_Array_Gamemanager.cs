using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex_Array_Gamemanager : MonoBehaviour {

    public GameObject[] EggAr;

    private Image[] EggImg = new Image[3];

    private int arnum;
    int ran_num;

    public Sprite N_Eggimg;
    public Sprite B_Eggimg;

    void Start()
    {
        for (arnum = 0; arnum < EggAr.Length; arnum++)
        {
            EggImg[arnum] = EggAr[arnum].GetComponent<Image>();
        }
    }

    public void EggPanClick()
    {
        Debug.Log("버튼 클릭");
        for (arnum = 0; arnum < EggAr.Length; arnum++)
        {
            ran_num = Random.Range(0, 2);

            if (arnum == 2)
            {
                if (ran_num == 0)
                    EggImg[arnum].sprite = N_Eggimg;
                else
                    EggImg[arnum].sprite = B_Eggimg;
            }
            else
                EggImg[arnum].sprite = EggImg[arnum + 1].sprite;
        }
    }

    public void FriedEggClick()
    {
        Debug.Log("깨진 버튼 클릭");
        for (arnum = 0; arnum < EggAr.Length; arnum++)
        {
            ran_num = Random.Range(0, 2);

            if (arnum == 2)
            {
                if (ran_num == 0)
                    EggImg[arnum].sprite = N_Eggimg;
                else
                    EggImg[arnum].sprite = B_Eggimg;
            }
            else
                EggImg[arnum].sprite = EggImg[arnum + 1].sprite;
        }
    }
}
