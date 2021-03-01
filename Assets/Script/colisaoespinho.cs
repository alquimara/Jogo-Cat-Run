using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisaoespinho : MonoBehaviour

{
    public GameObject asfalto;
    
    
        
 
   
void OnCollisionEnter2D(Collision2D colisao){
    
        pontuacao.score+=1;
        Destroy(gameObject);
        

    
    
           
    }

}
