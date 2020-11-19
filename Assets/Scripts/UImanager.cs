using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UImanager : MonoBehaviour
{
    [SerializeField] private Button play;
    [SerializeField] private Button quit;
    void Start()
    {
        play.onClick.AddListener(()=>{SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);});
        quit.onClick.AddListener(()=>{Application.Quit();});
    }
    void FixedUpdate()
    {
    
    }
}
