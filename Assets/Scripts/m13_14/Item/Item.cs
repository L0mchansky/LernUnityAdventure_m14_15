using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemEffect _effect;

    public ItemEffect Effect => _effect;

    public void Use(Character character)
    {
        _effect.Use(character);
        Destroy(gameObject);
    }
}