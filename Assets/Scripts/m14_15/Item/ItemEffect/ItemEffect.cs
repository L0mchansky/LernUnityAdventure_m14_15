using UnityEngine;

public abstract class ItemEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemPrefab;
    public abstract void Use(Character character);

    protected void CreateParticle(Character character)
    {
        Instantiate(_particleSystemPrefab, character.transform);
    }
}
