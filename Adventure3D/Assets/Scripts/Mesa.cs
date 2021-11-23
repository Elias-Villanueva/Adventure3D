using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mesa : MonoBehaviour
{
    public GameObject mesa1;
    public GameObject mesa2;
    public GameObject mesa3;
    public GameObject mesa4;
    public GameObject mesa5;
    public Inventory inventario;
    // Start is called before the first frame update
    void Start()
    {
        inventario = FindObjectOfType<Inventory>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            if (inventario.slot[0].GetComponent<Slot>().item != null)
            {
                mesa1.GetComponent<MeshRenderer>().material.color = Color.black;
                mesa2.GetComponent<MeshRenderer>().material.color = Color.black;
                mesa3.GetComponent<MeshRenderer>().material.color = Color.black;
                mesa4.GetComponent<MeshRenderer>().material.color = Color.black;
                mesa5.GetComponent<MeshRenderer>().material.color = Color.black;
            }
        }
    }
}
