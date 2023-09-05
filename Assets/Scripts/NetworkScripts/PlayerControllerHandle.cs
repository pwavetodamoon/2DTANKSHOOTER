using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class PlayerControllerHandle : NetworkBehaviour
{
    // Start is called before the first frame update
    private PlayerControllerBase _playerControllerBase;
    private void Awake()
    {
        _playerControllerBase = GetComponent<PlayerControllerBase>();
    }
    public override void FixedUpdateNetwork()
    {
        if (GetInput(out InputNetwork inputdata))
        {
            _playerControllerBase.Move(inputdata.Direction);
        }
    }
}
