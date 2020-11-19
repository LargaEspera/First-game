using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Music : MonoBehaviour
{
static private AudioSource flex;
    void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex != 5)
    {
        if (flex == null)
        {
        flex = this.GetComponent<AudioSource>();
        DontDestroyOnLoad(transform.gameObject);
        return;
        }
         Destroy(transform.gameObject);
    }
    else {
        Destroy(flex);
}}}
