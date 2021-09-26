using System.Collections;
using System.Collections.Generic;
using Kuhpik;
using UnityEngine;

public class FinishState : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        /*Сохраняем позицию плэйера*/
        player.PosX = game.player.position.x;
        player.PosY = game.player.position.y;
        player.PosZ = game.player.position.z;

        player.AngleX = game.player.eulerAngles.x;
        player.AngleY = game.player.eulerAngles.y;
        player.AngleZ = game.player.eulerAngles.z;
    }

    public void ButtonRestart()
    {
        Bootstrap.GameRestart(0);
    }
}
