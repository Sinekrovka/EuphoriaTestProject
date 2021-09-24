using System;
using UnityEngine;

public class InteratibleObject : MonoBehaviour
{
    public Action<Transform> checkNewObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InteractableObject"))
        {
            /*Здесь вызываем UI*/
            checkNewObject?.Invoke(other.transform);
        }
    }
}
