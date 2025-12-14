using UnityEngine;

public abstract class ItemEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystemPrefab;

    public abstract void Initialize(float value);
    public abstract void Use(Character character);

    protected void CreateParticle(Character character)
    {
        Instantiate(_particleSystemPrefab, character.transform);
    }
}
