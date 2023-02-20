using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShape : Shape
{
    // INHERITANCE
    public SphereShape()
    {
        Name = "Sphere";
        Color = "Green";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        Debug.Log("This is a " + Color + " " + Name + ".");
    }
}
