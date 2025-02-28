using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<MeshRenderer>().enabled = false;    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BallController>())
        {
            SceneController.RestartScene();
        }
    }
}
