using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class InteratibleObject : GameSystem
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            /*Здесь вызываем UI*/
            game.currentGameObjectFill = transform;
        }
    }
}
