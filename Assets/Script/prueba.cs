using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
   public GameObject textoFlotantePrefabs;

   private void OnTriggerEnter(Collider other){
      if(this.textoFlotantePrefabs){
          GameObject texto = Instantiate(textoFlotantePrefabs);
         texto.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z); 
      }

      
   }
}
