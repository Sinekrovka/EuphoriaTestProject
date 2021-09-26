using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class InteractibleObjectSystem : GameSystem, IIniting
{
    [SerializeField] private float forceMove;
    [SerializeField] private float forceFall;

    private Vector3 playerForward;
    private Transform placeForObject;
    
    private Rigidbody currentObjectOnHands;
    void IIniting.OnInit()
    {
        FindObjectOfType<InputSystem>().InteratibleObject += CheckingParams;
        FindObjectOfType<InteratibleObject>().CheckNewObjectEvent += CheckNewObject;
        FindObjectOfType<InteratibleObject>().removeObjectEvent += RemoveObject;
        placeForObject  = game.player.GetChild(0);
    }

    private void RemoveObject(Transform other)
    {
        if (game.currentGameObjectFill.Equals(other))
        {
            game.currentGameObjectFill = null;
        }
    }

    private void CheckNewObject(Transform other)
    {
        game.currentGameObjectFill = other;
    }

    private void CheckingParams(string parametr)
    {
        if (parametr.Contains("Raise"))
        {
            if (game.currentGameObjectFill != null)
            {
                RaiseObject();
            }
        }
        else
        {
            if (currentObjectOnHands != null)
            {
                FallObject(forceMove);
                if (currentObjectOnHands.transform.Equals(game.currentGameObjectFill))
                {
                    game.currentGameObjectFill = null;
                }
                currentObjectOnHands = new Rigidbody();
            }
        }
    }

    private void RaiseObject()
    {
        if (placeForObject.childCount > 0)
        {
            FallObject(forceFall);
        }
        
        currentObjectOnHands = game.currentGameObjectFill.GetComponent<Rigidbody>();
        currentObjectOnHands.isKinematic = true;
        game.currentGameObjectFill.GetComponent<Collider>().enabled = false;
        game.currentGameObjectFill.position = placeForObject.transform.position;
        game.currentGameObjectFill.transform.SetParent(placeForObject);
    }

    private void FallObject(float force)
    {
        playerForward = game.player.parent.forward;
        currentObjectOnHands.transform.SetParent(null);
        currentObjectOnHands.isKinematic = false;
        currentObjectOnHands.transform.GetComponent<Collider>().enabled = true;
        currentObjectOnHands.AddForce(playerForward * force);
        
    }
}
