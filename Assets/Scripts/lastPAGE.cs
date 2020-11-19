using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastPAGE : MonoBehaviour
{
    [SerializeField] private Button quit;
    void Start()
    {
       quit.onClick.AddListener(()=>{Application.Quit();});
    }
}
