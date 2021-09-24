using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEditor.PackageManager;
using UnityEngine;

public class CameraController : GameSystem, IUpdating
{
    void IUpdating.OnUpdate()
    {
        if (Input.GetKeyDown("Fire1"))
        {
            /*Смена камеры*/
            Debug.LogError("Смена Камеры");
        }
    }
}
