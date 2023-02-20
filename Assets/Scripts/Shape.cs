using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private string _name;
    private string _color;

    // ENCAPSULATION
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // ENCAPSULATION
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    // ABSTRACTION
    public virtual void DisplayText()
    {
        Debug.Log("This is a shape.");
    }
}
