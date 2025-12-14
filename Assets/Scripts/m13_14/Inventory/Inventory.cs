using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventorySlot _slot;

    public InventorySlot Slot => _slot;

    public bool AddItem(Item item)
    {
        if (_slot == null)
            return false;

        if (_slot.IsEmpty == true)
        {
            _slot.Occupy(item);
            return true;
        }

        return false;
    }
}