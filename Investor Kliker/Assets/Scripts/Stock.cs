using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Stock", menuName = "Investor/Stock", order = 51)]

public class Stock : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public int  Income { get; private set; }
    [field: SerializeField] public int BuyPrice { get; private set; }
    [field: SerializeField] public int SellPrice { get; private set; }
    [field: SerializeField] public Sprite Icon { get; private set; }

}
