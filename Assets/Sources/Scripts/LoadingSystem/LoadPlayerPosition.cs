using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class LoadPlayerPosition : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        /*здесь код загрузки позиции и поворота плэйера на момент выигрыша*/
        game.player = GameObject.FindWithTag("Player").transform;
        game.fpc = FindObjectOfType<FirstPersonController>();
        game.fpc.enabled = false;
        Bootstrap.ChangeGameState(EGamestate.Menu);
    }
}
