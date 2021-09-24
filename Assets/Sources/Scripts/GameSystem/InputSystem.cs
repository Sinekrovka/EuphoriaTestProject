using System;
using System.Threading.Tasks;
using Kuhpik;
using UnityEngine;

public class InputSystem : GameSystem, IIniting, IUpdating
{
    private bool wait;
    public event Action<string> ChangeCameraEvent;
    public event Action<string> InteratibleObject;

    void IIniting.OnInit()
    {
        wait = false;
        WaitTime(3000);
    }
    
    void IUpdating.OnUpdate()
    {
        if (Input.GetButton("Fire2") && wait)
        {
            wait = false;
            ChangeCameraEvent?.Invoke("Change");
            WaitTime(1000);
        }

        if (Input.GetButton("Raise"))
        {
            InteratibleObject?.Invoke("Raise");
        }

        if (Input.GetButton("Fire1"))
        {
            InteratibleObject?.Invoke("Fall");
        }
    }
    
    private async void WaitTime(int time)
    {
        await Task.Delay(time);
        wait = true;
    }
}
