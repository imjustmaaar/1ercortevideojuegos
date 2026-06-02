using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTuberia : MonoBehaviour
{
    [SerializeField] private float velocidadTuberia; 
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.right * velocidadTuberia * Time.deltaTime; 
    }
}
