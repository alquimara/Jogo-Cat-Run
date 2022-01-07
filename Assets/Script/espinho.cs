using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinho : MonoBehaviour
{
    public static float espinhos;
   
    public  GameObject espinhoprefab;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnEspinho());

    }

    private IEnumerator SpawnEspinho(){
         espinhos = Random.Range(1f, 1f);
        for(int i =0; i < espinhos; i++){
            var x = Random.Range(-1.7f,1.7f);
            var atrito = Random.Range(0f,4f);
            var respaldo = Instantiate (espinhoprefab, new Vector3(x, 5, 0), Quaternion.identity);
            respaldo.GetComponent<Rigidbody2D>().drag = atrito;

        }
         yield return new WaitForSeconds(1f);
         yield return SpawnEspinho();
       

    }

        
    
     

    
  
}
