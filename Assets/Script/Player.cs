using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ public float veloc ;
    public float entradaVertical ;
    public  GameObject pfTiro;

    void Start()
    {
       veloc = 3.0f ;
       transform.position = new Vector3(-7.09f,-0.06f,0); 
    }

    // Update is called once per frame
    void Update()
    {
      this.Movimento();
      if(Input.GetKeyDown(KeyCode.Space)){
        Instantiate(pfTiro,transform.position + new Vector3 (1.03f,-0.38f,0),Quaternion.identity);
      }
    }
        private void Movimento(){
        float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * entradaVertical * Time.deltaTime*veloc);
        if (transform.position.y < -3.09f) 
        {
            transform.position = new Vector3(transform.position.x,-3.09f,0);
        }
        else if(transform.position.y > 2.57f)
        {
            transform.position = new Vector3(transform.position.x,2.57f,0);
        }

        }
     
}
