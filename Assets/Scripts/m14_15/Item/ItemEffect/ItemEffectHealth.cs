using UnityEngine;
public class ItemEffectHealth : ItemEffect
{
    public float Health { get; private set; }
    
    public override void Initialize(float value)
    {
        if (value > 0)
        {
            Health = value;
        }
        else
        {
            Health = 0;
        }
    }

    public override void Use(Character character)
    {
        CreateParticle(character);
        character.Health += Health;
    }
}
