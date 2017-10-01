using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public void Start()
    {
    }

    public void Update()
    {
        var forward = Input.GetKey(KeyCode.W) ? 1.0f : 0.0f;
        var backward = Input.GetKey(KeyCode.S) ? -1.0f : 0.0f;
        var right = Input.GetKey(KeyCode.D) ? 1.0f : 0.0f;
        var left = Input.GetKey(KeyCode.A) ? -1.0f : 0.0f;
        var baseMovementVector = new Vector3(
            right + left, 
            0.0f, 
            forward + backward);
        var scaledMovementVector = baseMovementVector * Time.deltaTime;
        transform.position = transform.position + scaledMovementVector;
    }
}
