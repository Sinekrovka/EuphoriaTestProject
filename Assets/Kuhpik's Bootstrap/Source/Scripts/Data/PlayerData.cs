using NaughtyAttributes;
using System;

namespace Kuhpik
{
    /// <summary>
    /// Used to store player's data. Change it the way you want.
    /// </summary>
    [Serializable]
    public class PlayerData
    {
        public float PosX;
        public float PosY;
        public float PosZ;

        public float AngleX;
        public float AngleY;
        public float AngleZ;
    }
}