using UnityEngine;

public class ItemInteractor : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Character _character;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Item item) == false)
            return;

        if (_inventory.AddItem(item))
        {
            AddToParent(_character.ItemSocket.transform, item.transform);
        }
    }

    private void AddToParent(Transform parent, Transform child)
    {
        child.SetParent(parent, true);
        child.localPosition = Vector3.zero;
    }
}