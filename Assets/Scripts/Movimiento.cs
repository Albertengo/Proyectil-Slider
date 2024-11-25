using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    public Slider Mov_X;
    public Slider Mov_Y;
    public void Mov()
    {
        float InclinacionX = Mov_X.value;
        float InclinacionY = Mov_Y.value;
        transform.rotation = Quaternion.Euler(InclinacionY, InclinacionX, 0);
    }
}
