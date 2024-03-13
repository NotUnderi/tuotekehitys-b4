using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 2; i < 12; i++) {
            Instantiate(coin, new Vector3(i * 2.0f, 1, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
