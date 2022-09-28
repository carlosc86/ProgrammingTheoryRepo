using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormCanvas : MonoBehaviour
{
    public static FormCanvas Instance {get;private set;}
    [SerializeField]private List<GameObject> forms=new List<GameObject>();
    // Start is called before the first frame update
    void Awake(){
        Instance=this;
    }

    public void HideAllFormsPanels(){
        foreach(GameObject form in forms){
            form.SetActive(false);
        }
    }

}
