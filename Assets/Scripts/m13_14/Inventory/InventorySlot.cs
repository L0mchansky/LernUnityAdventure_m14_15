using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    private Item _item;

    public Item Item => _item;

    public bool IsEmpty
    {
        get
        {
            if (_item == null)
                return true;

            if (_item.gameObject == null)
                return true;

            return false;
        }
    }

    public void Occupy(Item item)
    {
        _item = item;
    }
}