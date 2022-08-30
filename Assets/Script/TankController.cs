
using UnityEngine;

public class TankController // Purely C# script 
{
    private TankModel tankModel;

    private TankView tankView;

    private Rigidbody rigidbody;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rigidbody = tankView.GetRigidbody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.ChangeColor(tankModel.color);

    }

    public void Move(float movement, float movementSpeed)
    {
        rigidbody.velocity = tankView.transform.forward * movement * movementSpeed;
    }
    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);  // How much delta our tank is rotating
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime); // Quaterion is measurement of rotation , Mesurements of angle at what we're rotating
        rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
