using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUIManager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI userName;
    void Start(){
        userName.SetText(AppPreferences.Instance.playerName);
    }
    
    public void ReturnToMenu(){
        SceneManager.LoadScene(0);
    }
}
