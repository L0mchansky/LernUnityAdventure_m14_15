using UnityEngine;

public class ItemEffectSpeed : ItemEffect
{
    [SerializeField] ParticleSystem _particleSystemPrefab;
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
        Instantiate(_particleSystemPrefab, character.transform);
        character.Speed += Speed;
    }
}