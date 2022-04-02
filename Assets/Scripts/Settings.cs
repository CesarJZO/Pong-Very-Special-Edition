using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : ScriptableObject
{
    float height;
    public float MaxHeight => height / 2;
    public float MinHeight => -height / 2;

    public void Hola()
    {
        
    }
}
