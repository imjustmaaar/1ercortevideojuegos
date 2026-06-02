using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMov : MonoBehaviour
{
    [SerializeField] private float velocidadFondo; 
    public float offsetAct; //desfase que se va a tener en el movimiento del fondo
    private SpriteRenderer fondo; //componente que se va a mover

    // Start is called before the first frame update
    void Start()
    {
        fondo = this.GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        offsetAct += velocidadFondo * Time.deltaTime; 

        fondo.material.mainTextureOffset = new Vector2(offsetAct, 0); 
    }
}
