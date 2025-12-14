using UnityEngine;

public class MoverTransform : MonoBehaviour
{
    public void ProcessTo(Vector3 normalizedDirection, float speed)
    {
        transform.Translate(normalizedDirection * speed * Time.deltaTime, Space.World);

        Debug.DrawRay(transform.position, normalizedDirection, Color.magenta);
    }
}