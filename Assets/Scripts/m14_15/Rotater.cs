using UnityEngine;

public class Rotater : MonoBehaviour
{
    public void ProcessTo(Vector3 direction, float rotationSpeed)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        float step = rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }
}