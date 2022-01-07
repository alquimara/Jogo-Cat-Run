using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text record;
    public int rec;
    public Text score;
    public int sco;
    // Start is called before the first frame update
    void Start()
    {
          if(PlayerPrefs.HasKey("record")){
            record.text = pontuacao.record.ToString();
        }
        if(PlayerPrefs.HasKey("score")){
            score.text = pontuacao.score.ToString();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(pontuacao.score > pontuacao.record){
            pontuacao.record = pontuacao.score;
            record.text = pontuacao.record.ToString();
            PlayerPrefs.SetInt("record", pontuacao.record);
            
             
        }
        score.text = pontuacao.score.ToString();
        PlayerPrefs.SetInt("score", pontuacao.score);
        
    }
}
