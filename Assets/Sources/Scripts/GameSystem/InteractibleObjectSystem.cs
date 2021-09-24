using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class InteractibleObjectSystem : GameSystem, IIniting
{
    [SerializeField] private Vector3 forceMove;
    [SerializeField] private Vector3 forceFall;
    
    private Rigidbody currentObjectOnHands;
    void IIniting.OnInit()
    {
        FindObjectOfType<InputSystem>().InteratibleObject += CheckingParams;
    }

    private void CheckingParams(string parametr)
    {
        if (parametr.Contains("Raise"))
        {
            RaiseObject();
        }
        else
        {
            FallObject(forceMove);
        }
    }

    private void RaiseObject()
    {
        Transform placeForObject = game.player.GetChild(0);
        if (placeForObject.childCount > 0)
        {
            FallObject(forceFall);
        }
        
        currentObjectOnHands = game.currentGameObjectFill.GetComponent<Rigidbody>();
        game.currentGameObjectFill.GetComponent<Collider>().enabled = false;
        currentObjectOnHands.isKinematic = true;
        game.currentGameObjectFill.position = placeForObject.transform.position;
        game.currentGameObjectFill.SetParent(placeForObject);
    }

    private void FallObject(Vector3 force)
    {
        currentObjectOnHands.isKinematic = false;
        currentObjectOnHands.transform.GetComponent<Collider>().enabled = true;
        currentObjectOnHands.AddForce(force);
    }
}
