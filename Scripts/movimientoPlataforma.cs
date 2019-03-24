﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPlataforma : MonoBehaviour
{
    //MOVIMIENTO PLATAFORMA DESDE UN INICIO A FIN MARCADOS

    public Transform punto;
    public float velocidad;
    private Vector3 inicio, fin;

    // Start is called before the first frame update
    void Start(){
       if (punto != null){
            punto.parent = null;
            inicio = transform.position;
            fin = punto.position;
        }
    }

    // Update is called once per frame
    void FixedUpdate(){
      if(punto != null) {
            float velocidadfija = velocidad * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, punto.position, velocidadfija);
        }
      if (transform.position == punto.position)
        {
            punto.position = (punto.position == inicio) ? fin : inicio;
        }




    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "goblin")
        {
            Debug.Log("toca");
           // col.transform.parent = transform;



        }
    }
       

}