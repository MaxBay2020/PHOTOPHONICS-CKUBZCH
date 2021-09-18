using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<string> items = new List<string>()
    {
        "Cat",
        "Candle",
        "Kite",
        "Key",
        "Umbralla",
        "Bike",
        "Bus",
        "Zebra",
        "Zipper",
        "Chair",
        "Chicken"
    };

    public int index;

    public static GameManager _instance;

    private void Awake()
    {
        _instance = this;

    }


}
