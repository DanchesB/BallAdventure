using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BallController>())
        {
            SceneController.RestartScene();
        }
    }
}
