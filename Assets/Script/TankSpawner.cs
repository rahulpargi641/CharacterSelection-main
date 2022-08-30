using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    void CreateTank()
    {
        TankModel tankModel = new TankModel(30, 50);
        TankController tankController = new TankController(tankModel, tankView); // Creating TankController Object so constructor will be called 
        
    }
}
