using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditCart : MonoBehaviour
{
    public MeshRenderer[] llantas;
    public MeshRenderer carroseria;

    void Awake()
    {
        for (int i =0;i<llantas.Length;i++) {
            llantas[i].material.color = Color.green;
        }
        carroseria.material.color = Color.green;

        DontDestroyOnLoad(this);

    }
}
