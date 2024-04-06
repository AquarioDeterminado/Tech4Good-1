using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public TMP_Text coinText;
    public int currrentCoins = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "COINS: " + currrentCoins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increaseCoins(int v)
    {
        currrentCoins += v;
        coinText.text = "COINS: " + currrentCoins.ToString();
    }
}
