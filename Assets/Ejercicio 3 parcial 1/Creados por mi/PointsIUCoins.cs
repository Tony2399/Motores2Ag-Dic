using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsIUCoins : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = Singleton.instance.GetScore().ToString();
    }
}
