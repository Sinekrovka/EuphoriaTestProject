using System;
using UnityEngine;

public class InteratibleObject : MonoBehaviour
{
    public Action<Transform> CheckNewObjectEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InteractableObject"))
        {
            /*Здесь вызываем UI*/
            CheckNewObjectEvent?.Invoke(other.GetComponent<Transform>());
        }
    }
}
