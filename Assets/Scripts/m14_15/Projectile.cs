using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private MoverTransform _mover;
    [SerializeField] private float _timeToDestory;

    private float _speedProjectile;
    private float _time;

    public void Initialize(float speedProjectile)
    {  
        _speedProjectile = speedProjectile;
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _timeToDestory)
        {
            Destroy(gameObject);
        }

        _mover.ProcessTo(transform.forward.normalized, _speedProjectile);
    }
}
