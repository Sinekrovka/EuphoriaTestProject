using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class LoadPlayerPosition : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        /*здесь код загрузки позиции и поворота плэйера на момент выигрыша*/
        Bootstrap.ChangeGameState(EGamestate.Menu);
    }
}
