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
    private string playerName;
    private Color backgroundColor;
    // Start is called before the first frame update
    public void StartNew()
    {
        if(playerNameInput.text.Length>0){
            playerName=playerNameInput.text;
            Debug.Log("Player name: "+playerName); 
            SceneManager.LoadScene(1);

        }else{
            Debug.Log("You must input your name.");
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
