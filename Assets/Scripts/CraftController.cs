using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CraftController : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefab;
    [SerializeField]
    private Transform craftGrid;
    [SerializeField]
    private GameObject winPanel;

    public CraftSlot[,] _craftTable { get; private set; }
    public CraftResultSlot _resultSlot;

    public bool HasResultItem => _resultSlot._item != null;

    private Color32 craftedItemColor = new Color32(255, 255, 255, 255);

    public void Init()
    {
        _craftTable = new CraftSlot[3, 3];
        CreateSlotsPrefabs();
    }

    private void CreateSlotsPrefabs()
    {
        for (int i = 0; i < _craftTable.GetLength(0); i++)
            for (int k = 0; k < _craftTable.GetLength(1); k++)
            {
                var slot = Instantiate(slotPrefab, craftGrid, false);
                _craftTable[i, k] = slot.AddComponent<CraftSlot>();
            }
    }

    public void CheckCraft()
    {
        ItemInSlot newItem = null;

        int _currentRecipieW = 0;
        int _currentRecipieH = 0;
        int _currentRecipieWStartIndex = -1;
        int _currentRecipieHStartIndex = -1;

        for (int i = 0; i < _craftTable.GetLength(0); i++)
            for (int k = 0; k < _craftTable.GetLength(1); k++)
                if (_craftTable[i, k].HasItem)
                {
                    if (_currentRecipieHStartIndex == -1)
                        _currentRecipieHStartIndex = i;

                    _currentRecipieH++;
                    break;
                }

        for (int i = 0; i < _craftTable.GetLength(1); i++)
            for (int k = 0; k < _craftTable.GetLength(0); k++)
                if (_craftTable[k, i].HasItem)
                {
                    if (_currentRecipieWStartIndex == -1)
                        _currentRecipieWStartIndex = i;

                    _currentRecipieW++;
                    break;
                }

        var craftOrder = new Item[_currentRecipieH * _currentRecipieW];

        for (int orderId = 0, i = _currentRecipieHStartIndex; i < _currentRecipieHStartIndex + _currentRecipieH; i++)
            for (int k = _currentRecipieWStartIndex; k < _currentRecipieWStartIndex + _currentRecipieW; k++)
                craftOrder[orderId++] = _craftTable[i, k]._item?._item;

        foreach (var item in ItemsManager.instance.items)
            if (item.HasRecipie && item._recipie._itemsOrder.SequenceEqual(craftOrder))
            {
                newItem = new ItemInSlot(item, item._recipie._amount);
                break;
            }

        if (newItem != null && newItem._item._name == PlayerPrefs.GetString("currentCraftItemName"))
        {
            winPanel.SetActive(true);
            PlayerPrefs.SetString(newItem._item._name + "Color", (string) JsonUtility.ToJson(craftedItemColor));
        }
    }

    public void CraftItem()
    {
        for (int i = 0; i < _craftTable.GetLength(0); i++)
            for (int k = 0; k < _craftTable.GetLength(1); k++)
                if (_craftTable[i, k]._item != null)
                    _craftTable[i, k].DecreaseItemAmount(1);

        CheckCraft();
    }
}
