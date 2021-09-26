using System;
using Kuhpik;
using UnityEngine;

public class PlatformController : GameSystem
{
    [SerializeField] private ParticleSystem particleOnTheDestroy;
    
    public Action<GameObject> GetNewObjectOnPlatform;
    
    public void RemoveObject(GameObject otherGameObject)
    {
        particleOnTheDestroy.gameObject.SetActive(true);
        particleOnTheDestroy.transform.position = otherGameObject.transform.position;
        particleOnTheDestroy.Play();
        /*Здесь может еще проигрываться какой нибудь звук*/
        GetNewObjectOnPlatform.Invoke(otherGameObject);
        otherGameObject.SetActive(false);
    }
}
