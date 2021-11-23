using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotDAmage : MonoBehaviour
{
    public int damage;

    public GameObject Player;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            Player.GetComponent<DatosJugador>().vidaPlayer -= damage;
        }
    }
 
}
