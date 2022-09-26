using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppPreferences : MonoBehaviour
{
    public static AppPreferences Instance {get; private set;}//read only
    private Color m_BackgroundColor;
    public string playerName;
    public Color backgroundColor {get{return m_BackgroundColor;}
                                  set{
                                    if(value!=null){//not null validation
                                        m_BackgroundColor=value;
                                    }
                                    }
                                 }

    void Awake(){
        if(Instance!=null){
            Destroy(gameObject);
            return;
        }
        Instance=this;
        DontDestroyOnLoad(gameObject);
    }
}
