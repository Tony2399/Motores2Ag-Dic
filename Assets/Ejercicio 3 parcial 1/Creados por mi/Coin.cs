using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : GameMonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

    

}
