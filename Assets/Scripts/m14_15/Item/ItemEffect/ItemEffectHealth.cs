using UnityEngine;
public class ItemEffectHealth : ItemEffect
{
    [SerializeField] ParticleSystem _particleSystemPrefab;
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
        Instantiate(_particleSystemPrefab, character.transform);
        character.Health += Health;
    }
}
