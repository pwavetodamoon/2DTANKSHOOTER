using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStats : MonoBehaviour
{
    [SerializeField] private TankStatsSO StatsSO;
    [SerializeField] private TankStatus Status;
    private void Awake()
    {
        SetTankStats();
    }
    private void SetTankStats()
    {
        if (StatsSO == null)
        {
            Debug.LogWarning("StatsSO is null");
            return;
        }
        StatsSO.GetStats(Status);
    }
}
[System.Serializable]
public struct TankStatus
{
    public int Health;
    public int Damage;
    public int Speed;
}
