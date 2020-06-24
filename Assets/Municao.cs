using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municao : MonoBehaviour
{
    public int velocidade;
    private Rigidbody corpo;

    // Start is called before the first frame update
    void Start()
    {
        corpo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        corpo.velocity = transform.forward * velocidade;
    }
}
