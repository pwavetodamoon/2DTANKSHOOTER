using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPlayer : NetworkRigidbody2D, IPlayerLeft
{
    public static NetworkPlayer local { get; set; }

    public override void Spawned()
    {
        base.Spawned();
        if (this.HasInputAuthority)
        {
            local = this;
            Debug.Log("We are local");
        }
        else
        {
            Debug.Log("Spawned remote player");
        }
    }

    public void PlayerLeft(PlayerRef player)
    {
    }
}