using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StockView : MonoBehaviour
{
    [SerializeField] private Stock _stock;
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _lable;

    public Stock Stock => _stock;

    private void Start()
    {
        _icon.sprite  = _stock.Icon;
        _lable.text = _stock.Name;
    }
}
