using UnityEngine;

public class ItemEffectSpeed : ItemEffect
{
    [SerializeField] private float _moveSpeed;

    public override void Use(Character character)
    {
        CreateParticle(character);

        character.MoveSpeed += _moveSpeed;
    }
}