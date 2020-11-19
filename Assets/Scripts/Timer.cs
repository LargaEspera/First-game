using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text timerText;
    void Start()
    {
        timerText.text = timeStart.ToString();
    }


    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();
        if (timerText.text == "0") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if (Input.GetKey(KeyCode.M))
        {
            if (Input.GetKey(KeyCode.N)){
                if (Input.GetKey(KeyCode.O)){
            timeStart = 120;
                }
            }
        }
    }
}
