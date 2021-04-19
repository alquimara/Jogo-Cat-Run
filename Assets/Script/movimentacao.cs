using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimentacao : MonoBehaviour
{
    private Rigidbody2D personagemRB;
    private float velocidade;
    public bool flipx;
    private SpriteRenderer spriteRenderer;
    


    // Start is called before the first frame update
    void Start()
    {
        personagemRB = GetComponent<Rigidbody2D>();
        velocidade = 1.9f;
        spriteRenderer = GetComponent<SpriteRenderer>();
    
        
    }

    // Update is called once per frame
    void Update(){
    if(Input.GetMouseButtonDown(0)){
        velocidade = velocidade * -1;
         flipx = !flipx;
        spriteRenderer.flipX = flipx;

    } else{
          personagemRB.velocity = new Vector2(velocidade, personagemRB.velocity.y);
    }
    
    
    }
    void OnCollisionEnter2D(Collision2D colisao){
        if(colisao.gameObject.CompareTag("espinho")){
            SceneManager.LoadScene("gameover");
            
           
        }
    }
}
