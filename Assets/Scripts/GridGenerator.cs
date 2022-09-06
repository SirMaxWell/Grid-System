using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject gridPrefab; // the object that will be used to create the grid // ex cube 
    //public GameObject nodePrefab;
    private GameObject[,] gridNodes;
    public int gridZ; 
    public int gridX;
    //private Node node;

    public float nodeRadius = 1;
    public float nodeDiameter;
    public float gridSpacingOffset = 1f; // how separated the user wants the grid 
    public Vector3 gridOrgin = Vector3.zero; // uses a set orgin instead of the position of prefab // more flexible 

    // Start is called before the first frame update
    void Start()
    {
        gridNodes = new GameObject[gridX, gridZ];

        
        CreateGrid();
        //new Node(10, 10, 2f);
        
    }


    void CreateGrid()
    {
        // Nested For Loop // 
        for(int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                // creates the position for each grid which is passed to spawnGrid function 
                Vector3 spawnGridPosition = new Vector3(x * gridSpacingOffset,0, z * gridSpacingOffset) + gridOrgin;
                Vector3 spawnNodePosition = new Vector3(x * gridSpacingOffset,1, z * gridSpacingOffset) + gridOrgin;
                
                
                spawnGrid(spawnGridPosition, Quaternion.identity);
                //spawnNode(spawnNodePosition, Quaternion.identity);
                


            }
        }
    }
    void spawnGrid(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        GameObject clone = Instantiate(gridPrefab, positionToSpawn, rotationToSpawn);
        clone.transform.SetParent(gameObject.transform);
        clone.gameObject.name = "Grid Space ( X: " + positionToSpawn.x.ToString() + " , Z: " + positionToSpawn.z.ToString() + ")";
        
        
    }

    /*
    void spawnNode(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        GameObject obj = Instantiate(nodePrefab, positionToSpawn, rotationToSpawn);
        obj.transform.SetParent(gameObject.transform);
        obj.gameObject.name = "Node Space ( X: " + positionToSpawn.x.ToString() + " , Z: " + positionToSpawn.z.ToString() + ")";
        obj.GetComponent<Node>().worldPosition.x = positionToSpawn.x;
        obj.GetComponent<Node>().worldPosition.z = positionToSpawn.z;
        gridNodes[(int)positionToSpawn.x,(int)positionToSpawn.z] = obj;

        //if(obj)
        /*
        foreach(GameObject thing in gridNodes)
        {
            thing.GetComponent<Node>().walkable = true;
        }
        */
        
    }

    
    
    
    

    
    
    

    
    
    
    



