using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShape : Shape // INHERITANCE
{
    private float radius;//private, not accesible by other class
    protected override float Area()
    {
        return 4*Mathf.PI*(Mathf.Pow(radius , 2f));
    }

    protected override void LoadInfo()
    {
        radius=4.5f;
        shapeName="Sphere";
        shapeInfo="A round solid figure, or its surface, with every point on its surface equidistant"+
                   "from its centre.\n Its area is calculated by 4*PI*radius², i.e.: Radius=4.5 Area="+Area();
    }
    
}
