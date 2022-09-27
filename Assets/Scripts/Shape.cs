using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    protected Color colorShape;
    protected string shapeInfo;
    protected string shapeName;
    protected float shapeArea;
    [SerializeField]protected TextMeshProUGUI titlePanel;
    [SerializeField]protected TextMeshProUGUI textPanel;
    [SerializeField] private TextMeshProUGUI areaText;
    [SerializeField] protected GameObject formPanel;

    void Start(){
        LoadInfo();
    }
    void OnMouseDown(){
        DisplayInfo();
        FormCanvas.Instance.HideAllFormsPanels();
        ShowFormPanel(true);
    }
    public void ShowFormPanel(bool show){
        if(formPanel!=null){ //if exist
            formPanel.SetActive(show);//show or hide
        }
    }
    protected virtual void DisplayInfo(){//On click execute this method
        titlePanel.SetText(shapeName);
        textPanel.SetText(shapeInfo);
    }

    public virtual void CalculateArea(){
        float area=Area();
        areaText.SetText("Area: "+ area);
    }

    protected abstract void LoadInfo();//Load info about the shape
    protected abstract float Area(); //The data depends of the shape.
    
}
