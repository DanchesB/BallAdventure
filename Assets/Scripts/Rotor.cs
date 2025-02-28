using UnityEngine;

public class Rotor : MonoBehaviour
{
    [SerializeField] [Range(-1000f, 1000f)] private float rotateSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(0f, rotateSpeed * Time.fixedDeltaTime, 0f);
    }
}
