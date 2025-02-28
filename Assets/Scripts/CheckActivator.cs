using System;
using UnityEngine;
using UnityEngine.Events;

public class CheckActivator : MonoBehaviour
{
    public UnityEvent OnActivatorsContact;

    [SerializeField] private Activator[] activators;

    private void Awake()
    {
        activators = FindObjectsOfType<Activator>();
    }

    public void CheckActivation()
    {
        for (int i = 0; i < activators.Length; i++)
        {
            if (activators[i].gameObject.activeSelf == true && activators[i].isActive == false)
            {
                return;
            }
        }

        OnActivatorsContact.Invoke();
    }
}
