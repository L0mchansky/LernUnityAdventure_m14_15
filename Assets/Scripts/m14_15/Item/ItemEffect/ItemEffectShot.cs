using UnityEngine;

public class ItemEffectShot : ItemEffect
{
    [SerializeField] private Projectile _projectilePrefab;
    [SerializeField] private float _flightSpeed;

    public override void Use(Character character)
    {
        CreateParticle(character);

        Projectile projectile = Instantiate(_projectilePrefab, character.transform.position, character.transform.rotation);
        projectile.Initialize(_flightSpeed);
    }
}
