using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockMarket : MonoBehaviour
{
    [SerializeField] private List<Stock> _stocks;

    public IReadOnlyList<Stock> Stocks => _stocks;

}
