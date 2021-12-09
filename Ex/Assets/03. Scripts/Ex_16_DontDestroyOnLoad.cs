using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_16_DontDestroyOnLoad : MonoBehaviour {

    private static Ex_16_DontDestroyOnLoad s_Instance = null;

    //public static Ex_16_DontDestroyOnLoad instance
    //{
    //    get
    //    {
    //        return s_Instance;
    //    }
    //}

    void Awake()
    {
        if (s_Instance)
        {
            DestroyImmediate(this.gameObject);
            return;
        }

        s_Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
