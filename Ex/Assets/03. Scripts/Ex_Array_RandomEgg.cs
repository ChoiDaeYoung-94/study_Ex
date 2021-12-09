using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex_Array_RandomEgg : MonoBehaviour {

    int ran_num;

    public Sprite N_Eggimg;
    public Sprite B_Eggimg;
    private Image SourceImage;

    void Start()
    {
        ran_num = Random.Range(0, 2);

        SourceImage = gameObject.GetComponent<Image>();

        if (ran_num == 0)
        {
            SourceImage.sprite = N_Eggimg;
        }
        else
        {
            SourceImage.sprite = B_Eggimg;
        }
    }
}
