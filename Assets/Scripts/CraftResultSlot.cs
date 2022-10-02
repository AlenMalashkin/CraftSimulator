using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftResultSlot : Slot
{
    public override void LeftClick()
    {
        if (InventoryWindow.instance.HasCurrentItem || InventoryWindow.instance.craftController._resultSlot == null)
            return;

        InventoryWindow.instance.SetCurrentItem(_item);
        ResetItem();

        InventoryWindow.instance.craftController.CraftItem();
    }
}
