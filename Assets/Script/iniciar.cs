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

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "menu" || SceneManager.GetActiveScene().name == "gameover" ||
        SceneManager.GetActiveScene().name == "vitoria")
        {
            if(Input.GetMouseButtonDown(0)){
                 SceneManager.LoadScene("fase");
                
            }

            if(SceneManager.GetActiveScene().name == "vitoria"){
                PlayerPrefs.DeleteKey("record");
            }
        }
       
        }
    
   
        
        
        
       
        
    
}
