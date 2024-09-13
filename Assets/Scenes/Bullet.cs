using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(CR_Destr());
    }
    IEnumerator CR_Destr()
    {
        yield return new WaitForSeconds(3.0f);
        //DestroyImmediate(this.gameObject);
        PoolManager.instance.ReturnObjectToPool(this.gameObject);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PoolManager.instance.ReturnObjectToPool(this.gameObject);
        Destroy (other.gameObject);
    }
}
 