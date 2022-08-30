using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;
    private float rotation;

    public Rigidbody rigidbody;

    private void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        camera.transform.SetParent(transform);
        camera.transform.position = new Vector3(0f, 3f, -4f);

    }

    private void Update()
    {

        Movement();

        if(movement !=0)
        {
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }

        if(rotation !=0)
        {
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
        }
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }


    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
        if(rotation !=0)
        {
            Debug.Log("Rotation is fine");
        }



    }

    public Rigidbody GetRigidbody()
    {
        return rigidbody;
    }
}
