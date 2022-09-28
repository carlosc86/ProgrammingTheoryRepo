using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TitleUIManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameInput;
    
    // Start is called before the first frame update
    void Start(){
        playerNameInput.text=AppPreferences.Instance.playerName;
        if(AppPreferences.Instance.backgroundChange){
            GameObject.Find("Background").GetComponent<Renderer>().material.color=AppPreferences.Instance.backgroundColor; 
        }
        
    }
    public void StartNew()
    {
        if(playerNameInput.text.Length>0){
            AppPreferences.Instance.playerName=playerNameInput.text;
            SceneManager.LoadScene(1);

        }else{
            Debug.LogError("You must input a name.");
        }
        
    }

    public void QuitGame(){
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
