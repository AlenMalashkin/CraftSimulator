using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    public static ItemsManager instance;
    public List<Item> items;
    public Sprite[] itemSprites;

    private void Awake()
    {
        if (!instance)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        GenerateItems();
    }

    private void GenerateItems()
    {
        items = new List<Item>();

        // Wood
        items.Add(new Item("Wood", itemSprites[0]));
        // Wood plank
        var woodPlankRecipie = new Item[,]
        {
            { items[0] }
        };
        items.Add(new Item("Wood Plank", itemSprites[1], new CraftRecipie(woodPlankRecipie, 4)));

        // Stick
        var stickRecipie = new Item[,]
        {
            { items[1] },
            { items[1] }
        };
        items.Add(new Item("Stick", itemSprites[2], new CraftRecipie(stickRecipie, 4)));

        //Coal
        items.Add(new Item("Coal", itemSprites[3]));

        //Diamond
        items.Add(new Item("Diamond", itemSprites[4]));

        //Diamond pickaxe
        items.Add(new Item("Diamond Pickaxe", itemSprites[5]));

        //Torch
        var torchRecipie = new Item[,]
        {
            { items[3]},
            { items[2]}
        };
        items.Add(new Item("Torch", itemSprites[6], new CraftRecipie(torchRecipie, 4)));
        //Cobblestone
        items.Add(new Item("Cobblestone", itemSprites[7]));
        //Book
        items.Add(new Item("Book", itemSprites[8]));
        //Obsidian
        items.Add(new Item("Obsidian", itemSprites[9]));
        //Cremen
        items.Add(new Item("Cremen", itemSprites[10]));
        //Redstone
        items.Add(new Item("Redstone", itemSprites[11]));
        //Iron Bar 
        items.Add(new Item("Iron Bar", itemSprites[12]));
        //Compass
        var compassRecepie = new Item[,]
        {
            { null, items[12], null },
            { items[12],  items[11], items[12] },
            { null,  items[12], null }
        };
        items.Add(new Item("Compass", itemSprites[13], new CraftRecipie(compassRecepie, 1)));
        //List
        items.Add(new Item("List", itemSprites[14]));
        //Gold bar
        items.Add(new Item("Gold bar", itemSprites[15]));
        //Thread
        items.Add(new Item("Thread", itemSprites[16]));
        //Перо
        items.Add(new Item("Pero", itemSprites[17]));
        //Порох
        items.Add(new Item("Порох", itemSprites[18]));
        //Sand 
        items.Add(new Item("Sand", itemSprites[19]));
        //Печь
        items.Add(new Item("Печь", itemSprites[20]));
        //Вагонетка
        items.Add(new Item("Вагонетка", itemSprites[21]));
        //Chest
        items.Add(new Item("Chest", itemSprites[22]));
        //Нажимная плита
        items.Add(new Item("Нажимная плита", itemSprites[23]));
        //Boat
        items.Add(new Item("Boat", itemSprites[24]));
        //Музыкальный блок
        items.Add(new Item("Музыкальный блок", itemSprites[25]));
        //Нотный блок
        items.Add(new Item("Нотный блок", itemSprites[26]));
        //Bow
        items.Add(new Item("Bow", itemSprites[27]));
        //Milk
        items.Add(new Item("Milk", itemSprites[28]));
        //Egg
        items.Add(new Item("Egg", itemSprites[29]));
        //Sugar
        items.Add(new Item("Sugar", itemSprites[30]));
        //Пшеница
        items.Add(new Item("Пшеница", itemSprites[31]));
        //Cake 
        items.Add(new Item("Cake", itemSprites[32]));
        //Gold apple
        items.Add(new Item("Golden apple", itemSprites[33]));
        //Apple 
        items.Add(new Item("Apple", itemSprites[34]));
        //Белая шерсть
        items.Add(new Item("Белая шерсть", itemSprites[35]));
        //Какао бобы
        items.Add(new Item("Какао бобы", itemSprites[36]));
        //Cookie
        items.Add(new Item("Cookie", itemSprites[37]));
        //Bed
        items.Add(new Item("Bed", itemSprites[38]));
        //Ender pearl
        items.Add(new Item("Ender pearl", itemSprites[39]));
        //Ender eye
        items.Add(new Item("Ender eye", itemSprites[40]));
        //Iron block
        items.Add(new Item("Iron block", itemSprites[41]));
        //Кожа
        items.Add(new Item("Кожа", itemSprites[42]));
        //Glass
        items.Add(new Item("Glass", itemSprites[43]));
        //Nether star
        items.Add(new Item("Nether star", itemSprites[44]));
        //Седло
        items.Add(new Item("Седло", itemSprites[45]));
        //Маяк
        items.Add(new Item("Маяк", itemSprites[46]));
        //Наковальня
        items.Add(new Item("Наковальня", itemSprites[47]));
        //Ender Chest
        items.Add(new Item("Ender Chest", itemSprites[48]));
        //Fire ash
        items.Add(new Item("Fire ash", itemSprites[49]));
        //Железная решëтка
        items.Add(new Item("Железная решëтка", itemSprites[50]));
        //Golden Ignot
        items.Add(new Item("Golden Ignot", itemSprites[51]));

        // Craft items

        //Diamond Sword
        var swordRecipie = new Item[,]
        {
            {items[4]},
            {items[4]},
            {items[2]}
        };
        items.Add(new Item("Diamond Sword", itemSprites[1], new CraftRecipie(swordRecipie, 1)));
        //Axe
        var axeRecepie = new Item[,]
        {
            { items[4], items[4] },
            { items[4], items[2] },
            { null,  items[2] }
        };
        items.Add(new Item("Axe", itemSprites[1], new CraftRecipie(axeRecepie, 1)));
        //Arrow
        var arrowRecepie = new Item[,]
        {
            { items[10] },
            { items[2] },
            { items[17] }
        };
        items.Add(new Item("Arrow", itemSprites[1], new CraftRecipie(arrowRecepie, 1)));
        //Clock
        var clockRecepie = new Item[,]
        {
            { null, items[15], null },
            { items[15],  items[11], items[15] },
            { null,  items[15], null }
        };
        items.Add(new Item("Clock", itemSprites[1], new CraftRecipie(clockRecepie, 1)));
        //Pants
        var pantsRecepie = new Item[,]
        {
            { items[4], items[4], items[4] },
            { items[4],  null, items[4] },
            { items[4],  null, items[4] }
        };
        items.Add(new Item("Pants", itemSprites[1], new CraftRecipie(pantsRecepie, 1)));
        //Hoe
        var hoeRecepie = new Item[,]
        {
            { items[4], items[4] },
            { null, items[2] },
            { null,  items[2] }
        };
        items.Add(new Item("Hoe", itemSprites[1], new CraftRecipie(hoeRecepie, 1)));
        //Cut
        var cutRecepie = new Item[,]
        {
            { null, items[12] },
            { items[12], null }
        };
        items.Add(new Item("Cut", itemSprites[1], new CraftRecipie(cutRecepie, 1)));
        //Pickaxe
        var pickakeRecepie = new Item[,]
        {
            { items[4], items[4], items[4] },
            {null,  items[2], null },
            {null,  items[2], null}
        };
        items.Add(new Item("Pickaxe", itemSprites[1], new CraftRecipie(pickakeRecepie, 1)));
        //GApple
        var gappleRecepie = new Item[,]
        {
            {items[51], items[51], items[51]},
            {items[51],  items[34], items[51]},
            {items[51],  items[51], items[51]}
        };
        items.Add(new Item("GApple", itemSprites[1], new CraftRecipie(gappleRecepie, 1)));
        //TNT
        var tntRecepie = new Item[,]
        {
            {items[18], items[19], items[18]},
            {items[19],  items[18], items[19]},
            {items[18],  items[19], items[18]}
        };
        items.Add(new Item("TNT", itemSprites[1], new CraftRecipie(tntRecepie, 1)));
        //Helmet
        var helmetRecepie = new Item[,]
        {
            {items[4], items[4], items[4]},
            {items[4],  null, items[4]},
        };
        items.Add(new Item("Helmet", itemSprites[1], new CraftRecipie(helmetRecepie, 1)));
        //Helmet
        var armorRecepie = new Item[,]
        {
            {items[4], null, items[4]},
            {items[4],  items[4], items[4]},
            {items[4],  items[4], items[4]},
        };
        items.Add(new Item("Armor", itemSprites[1], new CraftRecipie(armorRecepie, 1)));
        //Rod
        var rodRecepie = new Item[,]
        {
            {null, null, items[2]},
            {null, items[2], items[16]},
            {items[2], null, items[16]},
        };
        items.Add(new Item("Rod", itemSprites[1], new CraftRecipie(rodRecepie, 1)));
        //Ender Chest
        var enderChestRecepie = new Item[,]
        {
            {items[9], items[9], items[9]},
            {items[9], items[40], items[9]},
            {items[9], items[9], items[9]},
        };
        items.Add(new Item("EnderChest", itemSprites[1], new CraftRecipie(enderChestRecepie, 1)));
        //Fire
        var fireRecepie = new Item[,]
        {
            {items[12], null},
            {null, items[10]}
        };
        items.Add(new Item("Fire", itemSprites[1], new CraftRecipie(fireRecepie, 1)));
        //Cake
        var cakeRecepie = new Item[,]
        {
            {items[28], items[28], items[28]},
            {items[30], items[29], items[30]},
            {items[31], items[31], items[31]},
        };
        items.Add(new Item("Cake", itemSprites[1], new CraftRecipie(cakeRecepie, 1)));
        //Vagonette
        var vagonetteRecepie = new Item[,]
        {
            {items[12], null, items[12]},
            {items[12], items[12], items[12]},
        };
        items.Add(new Item("Vagonette", itemSprites[1], new CraftRecipie(vagonetteRecepie, 1)));
        //Rail
        var railRecepie = new Item[,]
        {
            {items[12], null, items[12]},
            {items[12], items[2], items[12]},
            {items[12], null, items[12]},
        };
        items.Add(new Item("Rail", itemSprites[1], new CraftRecipie(railRecepie, 1)));
        //EnchTable
        var enchTableRecepie = new Item[,]
        {
            {null, items[8], null},
            {items[4], items[9], items[4]},
            {items[9], items[9], items[9]},
        };
        items.Add(new Item("EnchTable", itemSprites[1], new CraftRecipie(enchTableRecepie, 1)));
        //EnchTable
        var cookieRecepie = new Item[,]
        {
            {items[31], items[36], items[31]}
        };
        items.Add(new Item("Cookie", itemSprites[1], new CraftRecipie(cookieRecepie, 1)));
        //Saddle
        var saddleRecepie = new Item[,]
        {
            {items[42], items[42], items[42]},
            {items[42], items[16], items[42]},
            {items[12], null, items[12]}
        };
        items.Add(new Item("Saddle", itemSprites[1], new CraftRecipie(saddleRecepie, 1)));
        //Cell
        var cellRecepie = new Item[,]
        {
            {items[12], items[12], items[12]},
            {items[12], items[12], items[12]}
        };
        items.Add(new Item("Cell", itemSprites[1], new CraftRecipie(cellRecepie, 1)));
        //Note Block
        var noteBlockRecepie = new Item[,]
        {
            {items[1], items[1], items[1]},
            {items[1], items[11], items[1]},
            {items[1], items[1], items[1]}
        };
        items.Add(new Item("NoteBlock", itemSprites[1], new CraftRecipie(noteBlockRecepie, 1)));
        //Musical Block
        var musicalBlockRecepie = new Item[,]
        {
            {items[1], items[1], items[1]},
            {items[1], items[4], items[1]},
            {items[1], items[1], items[1]}
        };
        items.Add(new Item("MusicalBlock", itemSprites[1], new CraftRecipie(musicalBlockRecepie, 1)));
        //LIghtHouse
        var lighthouseRecepie = new Item[,]
        {
            {items[43], items[43], items[43]},
            {items[43], items[44], items[43]},
            {items[9], items[9], items[9]}
        };
        items.Add(new Item("LIghtHouse", itemSprites[1], new CraftRecipie(lighthouseRecepie, 1)));
        //Chest
        var chestRecepie = new Item[,]
        {
            {items[1], items[1], items[1]},
            {items[1], null, items[1]},
            {items[1], items[1], items[1]}
        };
        items.Add(new Item("Chest", itemSprites[1], new CraftRecipie(chestRecepie, 1)));
        //Freature
        var freatureRecepie = new Item[,]
        {
            {items[7], items[7], items[7]},
            {items[7], null, items[7]},
            {items[7], items[7], items[7]}
        };
        items.Add(new Item("Freature", itemSprites[1], new CraftRecipie(freatureRecepie, 1)));
    }
}
