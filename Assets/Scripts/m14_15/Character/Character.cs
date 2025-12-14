using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;

    [SerializeField] private float _health;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    [SerializeField] private ItemSocket _itemSocket;

    public ItemSocket ItemSocket => _itemSocket;
    public float RotationSpeed => _rotationSpeed;

    public float Health
    { 
        get 
        { 
            return _health; 
        } 

        set
        {
            if (value < 0)
                value = 0;
            _health = value; 
        } 
    }

    public float Speed
    {
        get
        {
            return _speed;
        }

        set
        {
            if (value < 0)
                value = 0;
            _speed = value;
        }
    }
}
