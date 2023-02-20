using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShape : Shape
{
    // INHERITANCE
    public CubeShape()
    {
        Name = "Cube";
        Color = "Red";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        Debug.Log("This is a " + Color + " " + Name + ".");
    }
}

