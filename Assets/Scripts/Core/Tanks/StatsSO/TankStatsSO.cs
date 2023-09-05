using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tank",menuName ="Tank/TankStatSO")]
public class TankStatsSO : ScriptableObject
{
    public TankStatus TankStatus;

    public void GetStats(TankStatus TankStatus)
    {
        TankStatus = this.TankStatus;
    }
}
