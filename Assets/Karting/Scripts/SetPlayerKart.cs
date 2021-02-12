using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerKart : MonoBehaviour
{
    public MeshRenderer[] tiredColor;
    public SkinnedMeshRenderer bodywordColor;
    // Start is called before the first frame update
    void Start()
    {
        ContentEdit contentEdit = FindObjectOfType<ContentEdit>();
        if (contentEdit != null)
        {
            for (int i = 0; i < tiredColor.Length; i++)
                tiredColor[i].material.color = contentEdit.colorTires;

            bodywordColor.material.color = contentEdit.bodywork;
        }
        else {
            Debug.LogWarning("not instaciate contentEdit");
        }

    }
}
