using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rigidBody;
    private bool mirandoDerecha = true;


private void Start()
    {
         
         rigidBody =   GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
    }

void ProcesarMovimiento()

{

//Logica Movimiento
float inputMovimiento = Input.GetAxis("Horizontal");

rigidBody.velocity =  new Vector2(inputMovimiento * velocidad, rigidBody.velocity.y);

GestionarOrientacion(inputMovimiento);

}

void GestionarOrientacion(float inputMovimiento)
{
    if ( (mirandoDerecha == true && inputMovimiento < 0) || (mirandoDerecha == false && inputMovimiento > 0))
    {
        mirandoDerecha = !mirandoDerecha;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
}

}
