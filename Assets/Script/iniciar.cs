using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class iniciar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
     public void Play(){
        //PlayerPrefs.DeleteKey("record");
        SceneManager.LoadScene("tutorial");


    }
    public void Exit(){
        Application.Quit();
    }
    public void StartMenu(){
        SceneManager.LoadScene("menu");
    }
    public void fase(){
        SceneManager.LoadScene("fase");
    }

    // Update is called once per frame
    void Update()
    {
       if(SceneManager.GetActiveScene().name == "vitoria"){
                PlayerPrefs.DeleteKey("record");
        }
         if(SceneManager.GetActiveScene().name == "tutorial"){
            if(Input.GetMouseButtonDown(0)){
                fase();

            }
        }
        
       
    }

           
}
