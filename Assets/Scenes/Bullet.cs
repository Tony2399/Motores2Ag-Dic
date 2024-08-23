using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(CR_Destr());
    }
    IEnumerator CR_Destr()
    {
        yield return new WaitForSeconds(3.0f);
        DestroyImmediate(this.gameObject);
        // Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy (this.gameObject);
        Destroy (other.gameObject);
    }
}
 