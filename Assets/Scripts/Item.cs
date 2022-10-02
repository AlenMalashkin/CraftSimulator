using UnityEngine;

public class Item
{
    public string _name { get; private set; }
    public Sprite _sprite { get; private set; }
    public CraftRecipie _recipie { get; private set; }

    public bool HasRecipie => _recipie != null;

    public Item (string name, Sprite sprite, CraftRecipie recipie = null)
    {
        _name = name;
        _sprite = sprite;
        _recipie = recipie;
    }
}
