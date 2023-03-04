using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementService : IPlayerMovementService
{
    private Rigidbody2D _rigidbody2D;

    public void InstanceRigidbody(Rigidbody2D RigidBody, PlayerMovement playerMovement)
    {
        _rigidbody2D = RigidBody;
      //  UnityEngine.MonoBehaviour.print(_rigidbody2D.name);
    }
   
}


public interface IPlayerMovementService
{
    public void InstanceRigidbody(Rigidbody2D RigidBody, PlayerMovement playerMovement);
}
