using UnityEngine;
using UnityEngine.Events;

public class Activator : MonoBehaviour
{
    public UnityEvent OnActive;
    public bool isActive = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BallController>())
        {
            isActive = true;

            OnActive.Invoke();
        }
    }

}
