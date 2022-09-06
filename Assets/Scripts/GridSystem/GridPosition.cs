using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GridPosition 
{
    // using a struct to pass in the values instead of a ref 
    // it acts like a vector3 but we dont have to convert using vector2int with x&y
    public int x;
    public int z;

    public GridPosition(int x, int z)
    {
        this.x = x;
        this.z = z;

    }

    public override string ToString()
    {
        return "x: " + x + "; z: " + z;
    }
}
