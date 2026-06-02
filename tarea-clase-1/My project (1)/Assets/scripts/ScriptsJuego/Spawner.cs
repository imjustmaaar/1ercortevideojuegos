using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo; 
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private float posicionY; 
    [SerializeField] private float tiempoDestruccion;
    private float temporizador;

   
    // Update is called once per frame
    void Update()
    {
        if(temporizador>tiempoMaximo) 
        {
            GameObject nuevoObstaculo = Instantiate(obstaculo); 
            nuevoObstaculo.transform.position = transform.position + new Vector3(0, Random.Range(-posicionY, posicionY), 0); 
            Destroy(nuevoObstaculo, tiempoDestruccion); 
            temporizador = 0;  
        }
        temporizador += Time.deltaTime;
    }
}
