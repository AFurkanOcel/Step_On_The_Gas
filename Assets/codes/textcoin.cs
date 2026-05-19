using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textcoin : MonoBehaviour
{
    public Text coinzero;
    public carcode carcode;
    public TMPro.TextMeshPro coin;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("!BEST RACING!");
    }

    // Update is called once per frame
    void Update()
    {
        coinzero.text = coin.text + carcode.coin.ToString();
    }
}

