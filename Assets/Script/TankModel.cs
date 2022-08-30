using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel // Purely in C#, main responsibilty to handle the data and pass the data
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(float _movement , float _rotation)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
