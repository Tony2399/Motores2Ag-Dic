using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : GameMonoBehaviour
{

    //DestroyImmediate(this.gameObject);
    private void OnTriggerEnter(Collider other)
    {
        Singleton.instance.AddCoins(10);
        Singleton.instance.GetScore().ToString();
        //PoolManager.instance.ReturnObjectToPool(this.gameObject);
        Destroy(this.gameObject);
        
    }
}
