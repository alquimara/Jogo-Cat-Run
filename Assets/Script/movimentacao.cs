using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimentacao : MonoBehaviour
{
    public static movimentacao intance;
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
        //admob.instance.RequestBanner();
    if(Input.GetMouseButtonDown(0)){
        velocidade = velocidade * -1;
         flipx = !flipx;
        spriteRenderer.flipX = flipx;

    } else{
          personagemRB.velocity = new Vector2(velocidade, personagemRB.velocity.y);
    }
    
    
    }

    public void GamerOver(){
        SceneManager.LoadScene("gameover");
    }
    void OnCollisionEnter2D(Collision2D colisao){
        if(colisao.gameObject.CompareTag("espinho")){
           
            admob.instance.morte++;
            if(admob.instance.morte >=3){
                Time.timeScale = 0;
                AudioListener.pause = true;
                admob.instance.morte = 0;
                admob.instance.ShowBanner();
            }
            else{
                AudioListener.pause = false;
                 GamerOver();
            }
           
            
            
           
        }
    }
}
