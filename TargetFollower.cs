﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour 
{
    [SerializeField]
    private Transform _target;
    private Vector3 followPlayer;

    [SerializeField]
    private Vector3 _offset;
    public Vector3 Offset { get { return _offset; } set { _offset = value; } }


    public void FollowTargetInPos()
    {
       transform.position = _target.position + _offset;
    }

    private void LateUpdate()
	{
        transform.LookAt(_target);
    }
}
