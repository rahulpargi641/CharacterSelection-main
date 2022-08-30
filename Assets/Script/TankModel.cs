using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel // Purely in C#, main responsibilty to handle the data and pass the data
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankTypes tankType;
    public Material color;




    public TankModel(float _movement , float _rotation, TankTypes _tankType, Material _color)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        tankType = _tankType;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
