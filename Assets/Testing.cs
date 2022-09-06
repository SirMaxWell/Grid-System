using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    [SerializeField] private GameObject gridObject;
    private GridSystem gridSystem;
    // Start is called before the first frame update
    void Start()
    {
        gridSystem = new GridSystem(10, 10, 10f);
        gridSystem.CreateDebugObject(gridObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
