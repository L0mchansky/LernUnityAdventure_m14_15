using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private string _horizontalAxisName = "Horizontal";
    private string _verticalAxisName = "Vertical";

    [SerializeField] private Character _character;
    [SerializeField] private Inventory _inventory;

    [SerializeField] private MoverCharacterController _moverCharacterController;
    [SerializeField] private Rotater _rotater;

    private float _deadZone = 0.1f;

    private void Update()
    {
        Movement();
        UseItem();
    }

    private void UseItem()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            Item item = _inventory.Slot.Item;

            if (item != null)
            {
                item.Use(_character);
            }
            else
            {
                Debug.Log("Отсутствует предмет для использования!");
            }
        }
    }

    private void Movement()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(_horizontalAxisName), 0, Input.GetAxisRaw(_verticalAxisName));

        if (input.magnitude <= _deadZone)
            return;

        Vector3 normalizedInput = input.normalized;

        _moverCharacterController.ProcessTo(normalizedInput, _character.Speed);
        _rotater.ProcessTo(normalizedInput, _character.RotationSpeed);
    }
}