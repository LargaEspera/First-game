using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sakad : MonoBehaviour
{
static private AudioSource flex1;
    void Awake()
    {
         DontDestroyOnLoad(transform.gameObject);
        if (SceneManager.GetActiveScene().buildIndex == 5)
   {
       
        if (flex1 == null)
        {
        flex1 = this.GetComponent<AudioSource>();
        DontDestroyOnLoad(transform.gameObject);
        return;
        }
        Destroy(transform.gameObject);
    
    }
    else {
        Destroy(flex1);
}}}