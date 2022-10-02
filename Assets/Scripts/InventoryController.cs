using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public Slot[,] _mainSlots { get; private set; }
    public Slot[,] _additionalSlot { get; private set; }

    [SerializeField]
    private GameObject slotPref;
    [SerializeField]
    private Transform mainSlotGrid;

    public void Init()
    {
        InitTestInventory();
    }

    public void InitTestInventory()
    {
        _mainSlots = new Slot[1, 9];

        CreateSlotsPrefsbs();

        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[0], 4));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[1], 4));
        _mainSlots[0, 2].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 4));
        _mainSlots[0, 3].SetItem(new ItemInSlot(ItemsManager.instance.items[3], 4));
        _mainSlots[0, 4].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 4));
        _mainSlots[0, 5].SetItem(new ItemInSlot(ItemsManager.instance.items[5], 1));
    }
    
    public void InitCraftInventory(int itemInventoryIndex, int itemIndex, int itemsCount)
    {
        _mainSlots = new Slot[1, 9];
        
        CreateSlotsPrefsbs();
        
        ItemSetter(itemInventoryIndex, itemIndex, itemsCount);
    }
    
    public void ItemSetter(int slot, int itemIndex, int itemsCount)
    {
        _mainSlots[0, slot].SetItem(new ItemInSlot(ItemsManager.instance.items[itemIndex], itemsCount));
    }

    public void CreateSlotsPrefsbs()
    {
        for (int i = 0; i < _mainSlots.GetLength(1); i++)
        {
            var slot = Instantiate(slotPref, mainSlotGrid, false);
            _mainSlots[0, i] = slot.AddComponent<Slot>();
        }
    }
}
