using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private string TagPlatform;
    [SerializeField] private PlatformController controller;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains(TagPlatform) && other.CompareTag("InteractableObject"))
        {
            controller.RemoveObject(other.gameObject);
        }
    }
}
