using System;
using System.Collections.Generic;

public class StockMarket : IStock
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _stockName;
    private double _price;

    public StockMarket(string stockName, double initialPrice)
    {
        _stockName = stockName;
        _price = initialPrice;
    }

    public void SetPrice(double newPrice)
    {
        _price = newPrice;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_stockName, _price);
        }
    }
}
