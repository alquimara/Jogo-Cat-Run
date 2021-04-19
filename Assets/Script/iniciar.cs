using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class iniciar : MonoBehaviour
{
    public Text nomejogadordigitado;
 
    public  static string jogadordigitado;

    public static List<string> jogadores;

    private int jogadores_count = 0;
    public static string j;
    

    void Start()
    {
        //jogadores = new List<string>();
       
         if(jogadores == null){
            jogadores = new List<string>();
        }
        else{
            print(jogadores.Count);
        }

        
    }

   
     public void Play(){
       
        jogadordigitado = nomejogadordigitado.text;
        jogadores.Add(jogadordigitado);
    

        

       
        foreach( string j in jogadores){
            if(PlayerPrefs.HasKey(j)){
                jogadordigitado = PlayerPrefs.GetString(j);  
                print("estou no if" + j); 
            }

            else{
               
                PlayerPrefs.SetString(j,jogadordigitado);
                print("estou no else" + j);
                
            }
            print(jogadores.Count);
       
             

       }
        //PlayerPrefs.SetString("jogador",jogadordigitado);
        
        
        SceneManager.LoadScene("fase");


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
