using UnityEngine;

public class CraftRecipie
{
    public Item[,] _items { get; private set; }
    public int _amount { get; private set; }
    public Item[] _itemsOrder { get; private set; }

    public CraftRecipie(Item[,] items, int amount)
    {
        _items = items;
        _amount = amount;

        _itemsOrder = new Item[_items.Length];

        for (int orderId = 0, i = 0; i < _items.GetLength(0); i++)
        {
            for (int k = 0; k < _items.GetLength(1); k++)
            {
                _itemsOrder[orderId++] = _items[i, k];
            }
        }
    }
}
