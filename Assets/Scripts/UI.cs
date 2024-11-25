using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Movimiento slider_X;
    [SerializeField] Movimiento slider_Y;
    public TextMeshProUGUI Text_Info;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Text_Info = ("Angulo horizontal: " + slider_X);
    }
}
