using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class InteractibleObjectSystem : GameSystem, IIniting
{
    
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
            FallObject();
        }
    }

    private void RaiseObject()
    {
        
    }

    private void FallObject()
    {
        
    }
}
