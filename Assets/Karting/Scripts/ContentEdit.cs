using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentEdit : MonoBehaviour
{
    public Color colorTires;
    public Color bodywork;

    public void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
