using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    public static InventoryWindow instance;

    public CraftController craftController;
    public InventoryController inventoryController;

    [SerializeField]
    private Image currentItemImage;

    public ItemInSlot currentItem;

    public bool HasCurrentItem => currentItem != null;

    private void Awake()
    {
        instance = this;
        craftController.Init();
        inventoryController.Init();
    }

    public void SetCurrentItem(ItemInSlot item)
    {
        currentItem = item;
        currentItemImage.gameObject.SetActive(true);
        currentItemImage.sprite = currentItem._item._sprite;
    }

    public void ResetCurrentItem()
    {
        currentItem = null;
        currentItemImage.gameObject.SetActive(false);
    }

    public void CheckCurrentItem()
    {
        if (currentItem != null && currentItem._amount < 1)
            ResetCurrentItem();
    }

    private void Update()
    {
        if (currentItem == null)
            return;

        currentItemImage.transform.position = Input.mousePosition;
    }
}
