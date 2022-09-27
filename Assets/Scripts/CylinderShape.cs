using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CylinderShape : Shape
{
    [SerializeField]private TMP_InputField radiusInput;
    [SerializeField]private TMP_InputField heightInput;
    private float radius;
    private float height;
    protected override float Area()
    {
        return 2*Mathf.PI*radius*(height+radius);
    }

    protected override void LoadInfo()
    {
        shapeName="Cylinder";
        shapeInfo="A solid geometrical figure with straight parallel sides and a circular or oval cross section.";
    }

    public override void CalculateArea(){
        radius=float.Parse(radiusInput.text);
        height=float.Parse(heightInput.text);
        base.CalculateArea();
    }
}
