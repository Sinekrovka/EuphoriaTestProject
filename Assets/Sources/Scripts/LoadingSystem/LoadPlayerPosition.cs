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


        if (player.PosY > 0)
        {
            game.player.position = new Vector3(player.PosX, player.PosY, player.PosZ);
            game.player.eulerAngles = new Vector3(player.AngleX, player.AngleY, player.AngleZ);
        }
        
        game.fpc = FindObjectOfType<FirstPersonController>();
        game.fpc.enabled = false;

        GameObject[] gameObjectsType = GameObject.FindGameObjectsWithTag("InteractableObject");

        for (int i = 0; i < gameObjectsType.Length; ++i)
        {
            if (gameObjectsType[i].name.Contains("Sphere"))
            {
                game.countSphere += 1;
            }
            
            if (gameObjectsType[i].name.Contains("Cube"))
            {
                game.countCube += 1;
            }
            
            if (gameObjectsType[i].name.Contains("Capsule"))
            {
                game.countCapsule += 1;
            }
        }
        
        Bootstrap.ChangeGameState(EGamestate.Game);
    }
}
