using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jogadores : MonoBehaviour
{
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(texto.CompareTag("jogadores")){
            print(texto.text);
        }
        
    }
}
