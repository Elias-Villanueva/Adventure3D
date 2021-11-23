using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Disparo : MonoBehaviour
{

    public Camera camaraPrimeraPersona;
    public float hitDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
    {
       Ray ray = camaraPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
       RaycastHit hit;

       if ((Physics.Raycast(ray, out hit) == true) && hit.distance < hitDistance)
       {
            Debug.Log("El rayo tocó al objeto: " + hit.collider.name);

            if (hit.collider.name.Substring(0, 3) == "Bot")
            {
                GameObject objetoTocado = hit.collider.gameObject;
                ControlBot scriptObjetoTocado = (ControlBot)objetoTocado.GetComponentInParent((typeof(ControlBot)));

                if (scriptObjetoTocado != null)
                {
                    scriptObjetoTocado.recibirDaño();
                }
            }
       }
    }
    }
}
