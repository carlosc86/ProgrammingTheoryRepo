using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeShape : Shape
{
    [SerializeField]private TMP_InputField sideInput;
    
    private float m_side;
    //[SerializeField]private TMP_InputField inputSide;
    public float side   {get{return m_side;}
                        set {
                            if(value>0){
                                m_side=value;
                            }else{
                                Debug.LogError("The side must be positive.");
                            }
                        }}
    protected override float Area()
    {
        return 6*Mathf.Pow(m_side,2);
    }

    protected override void LoadInfo()
    {   
        shapeName="Cube";
        shapeInfo="A symmetrical three-dimensional shape, either solid or hollow, contained by six equal squares.";
    }
    public override void CalculateArea(){
        side=float.Parse(sideInput.text);//obtain the data of the input field
        base.CalculateArea();
    }
    

    

}
