using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.m_Instance.AddListener<SpawnCoinEvent>(SpawnCoinListener);//conecta para escuchar
    }

    // Update is called once per frame
    private void SpawnCoinListener(SpawnCoinEvent _event)
    {
        Coin newcoin;
        PoolManager.instance.SpawnObject<Coin>(out newcoin, CoinPrefab, this.transform);
    }
}
