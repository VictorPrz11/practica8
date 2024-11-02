using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Compuesto : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] float speed =10f;
    [SerializeField] float velocidad = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float angulo = 5f * speed*Time.deltaTime;
        //               x y z
        if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0,angulo*-1 ,0 );

        }
        else if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0,angulo ,0 );
        }


        if(Input.GetKey(KeyCode.W)){
        transform.position += transform.forward * velocidad * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.S)){
        transform.position+= transform.forward * -1 * velocidad* Time.deltaTime;
        }
 

 
        if(Input.GetKey(KeyCode.A)){
        transform.position += transform.right *-1* velocidad * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.D)){
        transform.position+= transform.right  * velocidad* Time.deltaTime;
        }
    } 
    }

