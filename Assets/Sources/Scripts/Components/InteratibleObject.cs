using System;
using UnityEngine;

public class InteratibleObject : MonoBehaviour
{
    public Action<Transform> CheckNewObjectEvent;
    public Action<Transform> removeObjectEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InteractableObject"))
        {
            /*Здесь вызываем UI*/
            CheckNewObjectEvent?.Invoke(other.GetComponent<Transform>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("InteractableObject"))
        {
            removeObjectEvent?.Invoke(other.GetComponent<Transform>());
        }
    }
}
