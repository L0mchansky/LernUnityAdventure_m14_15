using UnityEngine;
public class ItemEffectHealth : ItemEffect
{
    [SerializeField] private float _health;

    public override void Use(Character character)
    {
        CreateParticle(character);
        character.Health += _health;
    }
}
