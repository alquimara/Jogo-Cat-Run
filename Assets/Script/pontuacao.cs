using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pontuacao : MonoBehaviour
{
    public GameObject paredeespinhodireita;
    public GameObject paredeespinhoesquerda;
    public static int score;
    public static int record;
    public Text textoScore;
    public Text textoRecord;
    public Text nomejogador;
    public static Text nome;
  
    // Start is called before the first frame update
    void Start()
    {
    
        PlayerPrefs.DeleteKey("record");
        score = 0;
        if(PlayerPrefs.HasKey("record")){
            record = PlayerPrefs.GetInt("record");
        }else{
            PlayerPrefs.SetInt("record", record);
        }
        

    }

    // Update is called once per frame
    void Update()
    {

        for(var i = 0; i<iniciar.jogadores.Count; i++){
             print(iniciar.jogadores[i]);
            nomejogador.text = iniciar.jogadores[i];

            

        }
      

        
        //nomejogador.text = iniciar.jogadordigitado;
    

        textoScore.text = score.ToString();
        textoRecord.text = record.ToString();
        
        
    
        
        if(score>10){
            paredeespinhodireita.SetActive(true);

        }
        if(score> 15){
            paredeespinhoesquerda.SetActive(true);

        }
        if(score >30){
            espinho.espinhos = Random.Range(1f, 7f);

        }

        if(score >= 100){
            SceneManager.LoadScene("vitoria");
            
        }
        
        
    }
}
