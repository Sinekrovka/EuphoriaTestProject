using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class StartController : GameSystem, IUpdating
{
    void IUpdating.OnUpdate()
    {
        if (Input.anyKey)
        {
            Bootstrap.ChangeGameState(EGamestate.Game);
        }
    }
}
