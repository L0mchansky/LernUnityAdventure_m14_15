using UnityEngine;

public class ItemEffectSpeed : ItemEffect
{
    public float Speed { get; private set; }

    public override void Initialize(float value)
    {
        if (value > 0)
        {
            Speed = value;
        }
        else
        {
            Speed = 0;
        }
    }

    public override void Use(Character character)
    {
        CreateParticle(character);

        character.Speed += Speed;
    }
}