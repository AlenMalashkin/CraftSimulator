using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftSlot : Slot
{
    public override void LeftClick()
    {
        base.LeftClick();
        InventoryWindow.instance.craftController.CheckCraft();
    }

    public override void RightClick()
    {
        base.RightClick();
        InventoryWindow.instance.craftController.CheckCraft();
    }

    public void DecreaseItemAmount(int amount)
    {
        _item._amount -= amount;

        if (_item._amount < 1)
            ResetItem();

        RefreshUI();
    }
}
