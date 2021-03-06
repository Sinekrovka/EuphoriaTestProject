using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace Kuhpik
{
    /// <summary>
    /// Used to store game data. Change it the way you want.
    /// </summary>
    public class GameData
    {
        public Transform currentGameObjectFill;
        public Transform player;
        public FirstPersonController fpc;

        public int countSphere;
        public int countCapsule;
        public int countCube;

        public int currentCountSphere;
        public int currentCountCapsule;
        public int currentCountCube;
    }
}