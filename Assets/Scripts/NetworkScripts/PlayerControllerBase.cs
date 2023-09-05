using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using System.Data.Common;
using System.ComponentModel.Design;
using System;

public class PlayerControllerBase : NetworkTransform
{
    private Rigidbody2D _rigidbody2d;
    [SerializeField] private float _speed;

    protected override void Awake()
    {
        base.Awake();
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }
    public virtual void Move(Vector2 MoveDir)
    {

        transform.Rotate(0, 0, -MoveDir.x);
        transform.Translate(0, MoveDir.y * Runner.DeltaTime, 0);

    }


}

