using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public Slot[,] _mainSlots { get; private set; }
    public Slot[,] _additionalSlot { get; private set; }

    [SerializeField] private GameObject slotPref;
    [SerializeField] private Transform mainSlotGrid;

    public void Init()
    {
        string itemName = PlayerPrefs.GetString("currentCraftItemName");

        _mainSlots = new Slot[1, 9];

        CreateSlotsPrefsbs();

        switch(itemName)
        {
            case "Stick":
                InitStickCraftInventory();
            break;
            case "Diamond Sword":
                InitSwordCraftInventory();
            break;
            case "Compass":
                InitCompassCraftInventory();
            break;
            case "Axe":
                InitAxeCraftInventory();
            break;
            case "Arrow":
                InitArrowCraftInventory();
            break;
            case "Clock":
                InitClockCraftInventory();
            break;
            case "Pants":
                InitPantsCraftInventory();
            break;
            case "Boots":
                InitBootsCraftInventory();
            break;
            case "Hoe":
                InitHoeCraftInventory();
            break;
            case "Cut":
                InitCutCraftInventory();
            break;
            case "Pickaxe":
                InitPickaxeCraftInventory();
            break;
            case "GApple":
                InitGAppleCraftInventory();
            break;
            case "TNT":
                InitTNTCraftInventory();
            break;
            case "Torch":
                InitTorchCraftInventory();
            break;
            case "Helmet":
                InitHelmetCraftInventory();
            break;
            case "Armor":
                InitArmorCraftInventory();
            break;
            case "Rod":
                InitRodCraftInventory();
            break;
            case "EnderChest":
                InitEnderChestCraftInventory();
            break;
            case "Fire":
                InitFireCraftInventory();
            break;
            case "Cake":
                InitCakeCraftInventory();
            break;
            case "Vagonette":
                InitVagonetteCraftInventory();
            break;
            case "Rail":
                InitRailCraftInventory();
            break;
            case "EnchTable":
                InitEnchTableCraftInventory();
            break;
            case "Cookie":
                InitCookieCraftInventory();
            break;
            case "Saddle":
                InitSaddleCraftInventory();
            break;
            case "Cell":
                InitCellCraftInventory();
            break;
            case "NoteBlock":
                InitNoteBlockCraftInventory();
            break;
            case "MusicalBlock":
                InitMusicalBlockCraftInventory();
            break;
            case "LIghtHouse":
                InitLighthouseCraftInventory();
            break;
            case "Chest":
                InitChestCraftInventory();
            break;
            case "Freature":
                InitFreatureCraftInventory();
            break;
        }
    }

    public void InitStickCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[1], 2));
    }

    public void InitChestCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[1], 8));
    }

    public void InitFreatureCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[7], 8));
    }

    public void InitLighthouseCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[9], 3));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[43], 5));
        _mainSlots[0, 2].SetItem(new ItemInSlot(ItemsManager.instance.items[44], 1));
    }

    public void InitMusicalBlockCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[1], 8));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 1));
    }

    public void InitNoteBlockCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[1], 8));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[11], 1));
    }

    public void InitCellCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[12], 6));
    }

    public void InitSaddleCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[12], 2));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[16], 1));
        _mainSlots[0, 2].SetItem(new ItemInSlot(ItemsManager.instance.items[42], 5));
    }

    public void InitCookieCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[36], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[31], 2));
    }

    public void InitEnchTableCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[9], 4));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 2));
        _mainSlots[0, 2].SetItem(new ItemInSlot(ItemsManager.instance.items[8], 1));
    }

    public void InitRailCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[12], 6));
    }

    public void InitVagonetteCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[12], 5));
    }

    public void InitCakeCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[28], 3));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[29], 1));
        _mainSlots[0, 2].SetItem(new ItemInSlot(ItemsManager.instance.items[30], 2));
        _mainSlots[0, 3].SetItem(new ItemInSlot(ItemsManager.instance.items[31], 3));
    }

    public void InitFireCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[10], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[12], 1));
    }

    public void InitEnderChestCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[40], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[9], 8));
    }

    public void InitRodCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 3));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[16], 2));
    }

    public void InitArmorCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 8));
    }

    public void InitHelmetCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 5));
    }

    public void InitTorchCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[3], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 1));
    }

    public void InitTNTCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[19], 4));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[18], 5));
    }

    public void InitGAppleCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[34], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[51], 8));
    }

    public void InitPickaxeCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 2));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 3));
    }

    public void InitCutCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[12], 2));
    }

    public void InitHoeCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 2));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 2));
    }

    public void InitSwordCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 2));
    }
    public void InitPantsCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 7));
    }
    public void InitBootsCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 4));
    }

    public void InitCompassCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[11], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[12], 4));
    }

    public void InitAxeCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 2));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[4], 3));
    }

    public void InitArrowCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[2], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[10], 1));
        _mainSlots[0, 2].SetItem(new ItemInSlot(ItemsManager.instance.items[17], 1));
    }

    public void InitClockCraftInventory()
    {
        _mainSlots[0, 0].SetItem(new ItemInSlot(ItemsManager.instance.items[11], 1));
        _mainSlots[0, 1].SetItem(new ItemInSlot(ItemsManager.instance.items[15], 4));
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
