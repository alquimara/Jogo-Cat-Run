using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pontuacao.score > pontuacao.record){
            pontuacao.record = pontuacao.score;
            PlayerPrefs.SetInt("record", pontuacao.record);   
        }
        
    }
}
