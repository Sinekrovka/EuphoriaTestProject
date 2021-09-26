using System.Collections.Generic;
using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class UIController : GameSystem, IIniting
{
    [SerializeField] private Text UICounterSphere;
    [SerializeField] private Text UICounterCube;
    [SerializeField] private Text UICounterCapsule;
    
    void IIniting.OnInit()
    {
        FindObjectOfType<PlatformController>().GetNewObjectOnPlatform += CheckObject;
        UICounterSphere.text = 0 + "/" + game.countSphere;
        UICounterCube.text = 0 + "/" + game.countCube;
        UICounterCapsule.text = 0 + "/" + game.countCapsule;
    }

    private void CheckObject(GameObject x)
    {
        string name = x.name;
        if (name.Contains("Sphere"))
        {
            game.currentCountSphere += 1;
            UICounterSphere.text = game.currentCountSphere + "/" + game.countSphere;
        }
        
        if (name.Contains("Cu"))
        {
            game.currentCountCube += 1;
            UICounterCube.text = game.currentCountCube + "/" + game.countCube;
        }
        
        if (name.Contains("Caps"))
        {
            game.currentCountCapsule += 1;
            UICounterCapsule.text = game.currentCountCapsule + "/" + game.countCapsule;
        }

        if (game.currentCountCapsule == game.countCapsule && game.countCube == game.currentCountCube &&
            game.currentCountSphere == game.countSphere)
        {
            Bootstrap.GameRestart(1);
        }
    }
}
