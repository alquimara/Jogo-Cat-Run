using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class iniciar : MonoBehaviour
{
    //public Text nomejogadordigitado;
 
   // public  static string jogadordigitado;
    public static List<string> jogadores;
    // Start is called before the first frame update
    void Start()
    {
       
       
        jogadores = new List<string>();
       
       
       /* if(PlayerPrefs.HasKey("jogador")){
           jogadordigitado = PlayerPrefs.GetString("jogador");
        }else{
            PlayerPrefs.SetString("jogador",jogadordigitado);

        }*/
         
       
       
            

        
       
        
        
        
        
    }
     public void Play(){
        //PlayerPrefs.DeleteKey("record");
        //jogadordigitado = nomejogadordigitado.text;
        /*
        jogadores.Add(jogadordigitado);
        foreach(string j in jogadores){
           if(PlayerPrefs.HasKey(j)){
                jogadordigitado = PlayerPrefs.GetString(j);
                
            }
            else{
                PlayerPrefs.SetString(j,jogadordigitado);
                print("estou no else");
            
            }
             

       }
     
        
        
        //PlayerPrefs.SetString("jogador",jogadordigitado);
        
        */
        SceneManager.LoadScene("tutorial");


    }
    public void Exit(){
        Application.Quit();
    }
    public void StartMenu(){
        SceneManager.LoadScene("menu");
    }
    public void fase(){
        AudioListener.pause = false;
        Time.timeScale = 1;
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
