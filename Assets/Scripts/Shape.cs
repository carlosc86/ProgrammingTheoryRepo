using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    protected Color m_colorShape;
    protected string shapeInfo;
    protected string shapeName;
    protected float shapeArea;
    [SerializeField]protected TextMeshProUGUI titlePanel;
    [SerializeField]protected TextMeshProUGUI textPanel;
    [SerializeField] private TextMeshProUGUI areaText;
    [SerializeField] protected GameObject formPanel;
    public Color colorShape{get{return m_colorShape;}
                            set{
                                if(value!=null){
                                    m_colorShape=value;
                                }else {
                                    Debug.LogError("Can't assign a null value to a Color object");
                                }
                                    
                                }
                            }

    void Start(){
        colorShape=GetComponent<Renderer>().material.color;
        LoadInfo();
    }
    void OnMouseDown(){
        DisplayInfo();
        FormCanvas.Instance.HideAllFormsPanels();
        ShowFormPanel(true);
        AppPreferences.Instance.backgroundColor=colorShape;
    }
    public void ShowFormPanel(bool show){
        if(formPanel!=null){ //if exist
            formPanel.SetActive(show);//show or hide
        }
    }
    
    protected virtual void DisplayInfo(){ // ABSTRACTION
        //On click execute this method
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
