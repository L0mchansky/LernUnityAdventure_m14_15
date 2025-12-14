using UnityEngine;

public abstract class ItemEffect : MonoBehaviour
{
    public abstract void Initialize(float value);
    public abstract void Use(Character character);
}
