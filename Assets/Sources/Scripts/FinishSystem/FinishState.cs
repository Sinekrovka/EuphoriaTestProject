using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class FinishState : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        /*Сохраняем позицию плэйера*/
    }

    public void ButtonRestart()
    {
        Bootstrap.GameRestart(0);
    }
}
