public class ItemInSlot
{
    public Item _item { get; private set; }
    public int _amount { get; set; }
    public ItemInSlot(Item item, int amount)
    {
        _item = item;
        _amount = amount;
    }
}
