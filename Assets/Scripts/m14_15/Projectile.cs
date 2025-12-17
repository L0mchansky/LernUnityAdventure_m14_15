using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private MoverTransform _mover;
    [SerializeField] private float _timeToDestory;

    private float _speedProjectile;

    public void Initialize(float speedProjectile)
    {  
        _speedProjectile = speedProjectile;
    }

    private void Update()
    {
        Destroy(gameObject, _timeToDestory);

        _mover.ProcessTo(transform.forward.normalized, _speedProjectile);
    }
}
