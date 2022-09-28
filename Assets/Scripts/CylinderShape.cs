using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CylinderShape : Shape // INHERITANCE
{
    [SerializeField]private TMP_InputField radiusInput;
    [SerializeField]private TMP_InputField heightInput;
    public float radius{get;private set;}// ENCAPSULATION
    public float height{get;private set;}// ENCAPSULATION
    protected override float Area()
    {
        return 2*Mathf.PI*radius*(height+radius);
    }

    protected override void LoadInfo()
    {
        shapeName="Cylinder";
        shapeInfo="A solid geometrical figure with straight parallel sides and a circular or oval cross section.";
    }

    // POLYMORPHISM
    public override void CalculateArea(){
        radius=float.Parse(radiusInput.text);
        height=float.Parse(heightInput.text);
        base.CalculateArea();
    }
}
