using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    [SerializeField] private int pointsCount = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BallController>())
        {
            GameManager.Points += pointsCount;
            Destroy(gameObject);
        }
    }
}
