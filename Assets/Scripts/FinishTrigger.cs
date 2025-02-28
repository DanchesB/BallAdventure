using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BallController>())
        {
            SceneController.LoadNextScene();
        }
    }
}
