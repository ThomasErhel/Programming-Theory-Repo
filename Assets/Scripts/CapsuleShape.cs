using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleShape : Shape
{
    // INHERITANCE
    public CapsuleShape()
    {
        Name = "Capsule";
        Color = "Blue";
    }

    // POLYMORPHISM
    public override void DisplayText()
    {
        Debug.Log("This is a " + Color + " " + Name + ".");
    }
}
