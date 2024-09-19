using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton _instance;
    public static Singleton instance
    {

        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<Singleton>();
            return _instance;
        }
    }

    public void SpawnCoin()//Invoca el evento de SpawnCoinEvent, de ley
    {
       EventManager.m_Instance.InvokeEvent<SpawnCoinEvent>(new SpawnCoinEvent());
    }

    

    private int score = 0;

    public int GetScore()
    {
        return score;
    }
    public void AddCoins(int _value)
    {
        score += _value;
    }

}
