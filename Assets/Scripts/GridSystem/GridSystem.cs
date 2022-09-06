using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem 
{
    private int width;
    private int height;
    private float cellSize;
    private GridObject[,] gridObjectArray;
    public GridSystem(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridObjectArray = new GridObject[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                //Debug.DrawLine(GetWorldPosition(x, z), GetWorldPosition(x, z) + Vector3.right * 0.2f, Color.white, 1000);
                GridPosition gridPosition = new GridPosition(x,z);
               gridObjectArray[x,z] = new GridObject(this, gridPosition);
            }
        }
    }


    public Vector3 GetWorldPosition(int x, int z)
    {
        return new Vector3(x, 0, z) * cellSize;
    }


    public GridPosition GetGridPosition (Vector3 worldPosition)
    {
        return new GridPosition(
            Mathf.RoundToInt(worldPosition.x / cellSize),
            Mathf.RoundToInt(worldPosition.z / cellSize)
        );
    }

    public void CreateDebugObject(GameObject debugPrefab)
    {
        Vector3 LocalScale = new Vector3(cellSize, cellSize, cellSize);
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                GameObject debugGameObject = GameObject.Instantiate(debugPrefab, GetWorldPosition(x,z), Quaternion.identity);

                debugGameObject.transform.localScale = LocalScale;
            }
        }
    }

}
