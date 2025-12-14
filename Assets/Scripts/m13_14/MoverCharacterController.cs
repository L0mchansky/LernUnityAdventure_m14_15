using UnityEngine;

public class MoverCharacterController : MonoBehaviour
{
    [SerializeField] UnityEngine.CharacterController _characterController;

    public void ProcessTo(Vector3 normalizedDirection, float speed)
    {
        _characterController.Move(normalizedDirection * speed * Time.deltaTime);

        Debug.DrawRay(transform.position, normalizedDirection, Color.magenta);
    }
}