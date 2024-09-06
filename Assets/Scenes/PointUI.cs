using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PointIU : GameMonoBehaviour
{
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = PointManager.instance.GetScore().ToString();
            
    }

    public void OnClick_AddPoints()
    {
        //Desactivar el collider
        //Activar sfx sonido
        //Desactivar render mesh
        PointManager.instance.AddPoints(10);
    }
    public void OnClick_SubstractPoints()
    {
        PointManager.instance.RemovePoints(5);
    }

    public void OnClick_WinAnahuacEvent()
    {
        InvokeEvent<WinAnahuacRaffle_Event>(new WinAnahuacRaffle_Event());
    }
}
