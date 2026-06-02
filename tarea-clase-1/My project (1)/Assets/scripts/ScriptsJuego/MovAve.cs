using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAve : MonoBehaviour
{
    [SerializeField] private float ImpulsoAve = 200;
    private Rigidbody2D RigidbodyAve; //componente 


    // Start is called before the first frame update
    void Start()
    {
        RigidbodyAve = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        if ( Input.GetButtonDown("Fire1"))
        {
            Impulso();
        }
        
    }

    void Impulso()
    {
        
        RigidbodyAve.AddForce(Vector2.up * ImpulsoAve);
    }
}
