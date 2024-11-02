using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Placa : MonoBehaviour
{
    [SerializeField] GameObject obj1;
    [SerializeField] GameObject obj2;
    [SerializeField] GameObject obj3;
    [SerializeField] TextMeshProUGUI texto;
    public HandlerTomarObjetos instancia;
    Material colordefault;
    bool repeat;
    int seleccion, contador;

    // Start is called before the first frame update
    void Start()
    {
        repeat = true;
        colordefault = transform.GetComponent<Renderer>().material;
        contador = 0;
        instancia = new HandlerTomarObjetos();
        
    }

    // Update is called once per frame
    void Update()
    {

        while (repeat && contador < 3)
        {
            seleccion = Random.Range(1, 4);
            if (seleccion == 1 && obj1 != null)
            {
                transform.GetComponent<Renderer>().material = obj1.transform.GetComponent<Renderer>().material;
                repeat = false;
            }

            if (seleccion == 2 && obj2 != null)
            {
                transform.GetComponent<Renderer>().material = obj2.transform.GetComponent<Renderer>().material;
                repeat = false;
            }
            if (seleccion == 3 && obj3 != null)
            {
                transform.GetComponent<Renderer>().material = obj3.transform.GetComponent<Renderer>().material;
                repeat = false;
            }


        }
        if (contador == 3)
        {
            transform.GetComponent<Renderer>().material = colordefault;
            texto.GetComponent<TextMeshProUGUI>().enabled = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Renderer>() != null)
        {

            if (other.gameObject.GetComponent<Renderer>().material.color == transform.GetComponent<Renderer>().material.color)
            {
                repeat = true;

                if (other.gameObject == obj1)
                {
                    contador += 1;
                    Destroy(obj1);

                }
                else if (other.gameObject == obj2)
                {
                    contador += 1;
                    Destroy(obj2);
                }
                else if (other.gameObject == obj3)
                {
                    contador += 1;
                    Destroy(obj3);
                }


            }

            // }else{
            //     other.gameObject.transform.position = instancia.posicionInicialDelObjeto;

            // }
        }
    }
}
