using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class transicao : MonoBehaviour
{
    public static transicao transi;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    private void Awake() {
        if(transi == null)
        {
             transi = this;
             DontDestroyOnLoad(this.gameObject);
             Debug.Log(this.gameObject);
            

        }
       
    }
    // Update is called once per frame
   
}
