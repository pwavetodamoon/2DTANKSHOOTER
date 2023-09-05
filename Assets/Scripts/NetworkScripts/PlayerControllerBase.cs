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
        // Tính toán góc quay từ vector di chuyển
        float angle = Mathf.Atan2(MoveDir.x, MoveDir.y) * Mathf.Rad2Deg;
        // Debug.Log("angle: " + angle);
        // // Thiết lập góc quay của nhân vật
        // transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        transform.Rotate(0, 0, -MoveDir.x);
        transform.Translate(0, MoveDir.y * Runner.DeltaTime, 0);
        // Thiết lập vận tốc di chuyển
        // _rigidbody2d.velocity = MoveDir.normalized * _speed * Runner.DeltaTime;
        // _rigidbody2d.rotation = angle;
    }


}

