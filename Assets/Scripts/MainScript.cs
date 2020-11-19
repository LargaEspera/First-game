using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] KeyCode keyThree;
    [SerializeField] KeyCode keyFour;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] Vector3 moveDirection1;
    [SerializeField] Light svet; 
    [SerializeField] Light svet2;
[SerializeField] Transform camera;
float ghj = 0;
    private void FixedUpdate()
    {
        if (Input.GetKey("escape")) 
      {
         Application.Quit(); 
      }
        if (svet != null){
       svet.transform.Rotate(6.5f,0,0);
                svet.color = new Color(Random.Range(255,255),Random.Range(255,255),Random.Range(255,255));
                }
                if (svet2 != null){
       svet2.transform.Rotate(0,30f,0);
                svet2.color = new Color(Random.Range(0,5),Random.Range(0,5),Random.Range(0,5));
                }
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection*0.7f;
            Vector3 axis = new Vector3(0,0,0);
     camera.RotateAround(this.transform.position, axis, Time.deltaTime * 1000);
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection*0.7f;
            Vector3 axis = new Vector3(0,0,0);
     camera.RotateAround(this.transform.position, axis, Time.deltaTime * 1000);
        }
        if (Input.GetKey(keyThree))
        {
            GetComponent<Rigidbody>().velocity += moveDirection1*0.7f;
            Vector3 axis = new Vector3(0,-10,0);
     camera.RotateAround(this.transform.position, axis, Time.deltaTime * 1000);
        }
        if (Input.GetKey(keyFour))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection1*0.7f;
            Vector3 axis = new Vector3(0,10,0);
     camera.RotateAround(this.transform.position, axis, Time.deltaTime * 1000);
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.G))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    private void OnTriggerEnter (Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
