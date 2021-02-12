using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorCar : MonoBehaviour
{
    public Color[] colorTires;
    public ContentEdit contentEdit;

    public void AssignColorTires( int id) {
        contentEdit.colorTires = colorTires[id];
    }

    public void AssignColorBodyWork(int id)
    {
        contentEdit.bodywork = colorTires[id];
    }
}
