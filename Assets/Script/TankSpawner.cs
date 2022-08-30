using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] TankView tankView;
    // Start is called before the first frame update

    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;

        public TankTypes tankTypes;

        public Material color;
    }

    public List <Tank> tankList;

    void Start()
    {
        CreateTank();
    }

    void CreateTank()
    {
        // By default Green Tank will come
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankTypes, tankList[0].color);
        TankController tankController = new TankController(tankModel, tankView); // Creating TankController Object so constructor will be called 
        
    }
}
