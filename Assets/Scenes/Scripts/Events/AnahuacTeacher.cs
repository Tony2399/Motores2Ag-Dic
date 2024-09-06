using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacTeacher : GameMonoBehaviour
{
    private void Start()
    {
        AddEventListener<WinAnahuacRaffle_Event>(WinRaffle);
    }
    // Start is called before the first frame update
    public void WinRaffle(WinAnahuacRaffle_Event _event)
    {
        Debug.Log("Gane la rifa como profe");
    }
}
