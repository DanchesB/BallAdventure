using UnityEngine;

public class Batut : MonoBehaviour
{
    [SerializeField] private float batutPower = 10f;
    private void OnTriggerEnter(Collider other)
    {
        BallController ballController = other.GetComponent<BallController>();
        if (ballController != null)
        {
            ballController.Jump(batutPower);
        }
    }
}
