using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private StockMarket _stockMarket;
    [SerializeField] private TMP_Text _moneyBar;
    [SerializeField] private TMP_Text _activeBar;
    [SerializeField] private TMP_Text _passiveBar;

    private int _money;
    private int _activeIncome;
    private int _passiveIncome;
    private int _clicCount;

    private List<Stock> _stocks;


    //public event UnityAction<int> MoneyChanged;

    private void Start()
    {
        _money = 0;
        _activeIncome = 150;
        _passiveIncome = 0;

    }

    private void Update()
    {
        ShowInfoBar();
    }

    private void ShowInfoBar()
    {
        _moneyBar.text = $"Ваше состояние: {_money}";
        _activeBar.text = $"Ваш активный доход: {_activeIncome}";
        _passiveBar.text = $"Ваш пассивный доход {_passiveIncome} ";
    }

    public void BuyStock(int number)
    {
        if (_money >= _stockMarket.Stocks[number].BuyPrice)
        {
            TakeMoney(_stockMarket.Stocks[number].BuyPrice);
            _passiveIncome += _stockMarket.Stocks[number].Income;
        }
    }

    public void CalculateIncome()
    {
        _clicCount++;

        if (_clicCount >= 5)
        {
            _money += _passiveIncome;
            _clicCount = 0;
        }
    }

    private void TakeMoney(int price)
    {
        _money -= price;
        //MoneyChanged?.Invoke(_money);
    }

    private void GiveMoney(int income)
    {
        _money += income;
        //MoneyChanged?.Invoke(_money);
    }

    public void EarnMoney()
    {
        GiveMoney(_activeIncome);
        CalculateIncome();
    }
}
