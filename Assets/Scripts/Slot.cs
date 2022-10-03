using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Image image;
    private Image itemImage;
    private Text itemAmount;

    private Color defaultColor = new Color32(140, 140, 140, 255);
    private Color highlghitedColor = new Color32(121, 121, 121, 255);

    public ItemInSlot _item { get; private set; }
    public bool HasItem => _item != null;

    private void Awake()
    {
        image = GetComponent<Image>();
        itemImage = this.transform.GetChild(0).GetComponent<Image>();
        itemAmount = this.transform.GetChild(1).GetComponent<Text>();

        itemImage.preserveAspect = true;
    }

    public void SetItem(ItemInSlot item)
    {
        _item = item;
        RefreshUI();
    }

    public void AddItem(ItemInSlot item, int amount)
    {
        item._amount -= amount;

        if (!HasItem)
            SetItem(new ItemInSlot(item._item, amount));
        else
        {
            _item._amount += amount;
            RefreshUI();
        }
    }

    public void ResetItem()
    {
        _item = null;
        RefreshUI();
    }

    public void RefreshUI()
    {
        itemImage.gameObject.SetActive(HasItem);
        itemImage.sprite = _item?._item._sprite;

        itemAmount.gameObject.SetActive(HasItem && _item._amount > 1);
        itemAmount.text = _item?._amount.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            LeftClick();
        else
            RightClick();
    }

    public virtual void LeftClick()
    {
        var currItem = InventoryWindow.instance.currentItem;
        
        if (HasItem)
        {
            if (currItem == null || _item._item != currItem._item)
            {
                InventoryWindow.instance.SetCurrentItem(_item);
                ResetItem();
            }
            else
            {
                AddItem(currItem, currItem._amount);
                InventoryWindow.instance.CheckCurrentItem();
                return;
            }
        }
        else
        {
            InventoryWindow.instance.ResetCurrentItem();
        }

        if (currItem != null)
            SetItem(currItem);
    }

    public virtual void RightClick()
    {
        if (!InventoryWindow.instance.HasCurrentItem)
            return;

        if (!HasItem || InventoryWindow.instance.currentItem._item == _item._item)
        {
            AddItem(InventoryWindow.instance.currentItem, 1);
            InventoryWindow.instance.CheckCurrentItem();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = highlghitedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = defaultColor;
    }
}
