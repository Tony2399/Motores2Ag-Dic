using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            GameObject NewBullet = Instantiate(bulletPrefab);
            NewBullet.transform.position = spawnPoint.position;
            NewBullet.transform.rotation = spawnPoint.rotation;
            NewBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.transform.forward*200.0f);

            
        }

        
    }
}
