using UnityEngine;

public class ItemEffectShot : ItemEffect
{
    [SerializeField] private Projectile _projectilePrefab;

    public float SpeedProjectile { get; private set; }

    public override void Initialize(float value)
    {
        if (value > 0)
        {
            SpeedProjectile = value;
        }
        else
        {
            SpeedProjectile = 0;
        }
    }

    public override void Use(Character character)
    {
        CreateParticle(character);

        Projectile projectile = Instantiate(_projectilePrefab, character.transform.position, character.transform.rotation);
        projectile.Initialize(SpeedProjectile);
    }
}
