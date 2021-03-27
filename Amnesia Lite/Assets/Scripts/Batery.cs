using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batery : MonoBehaviour
{
    private Collider bateryCollision;

    private bool hasCollided = false;

    public Sound catchItem;

    void Start()
    {
        bateryCollision = GetComponent<Collider>();
    }

    //Comprobar si ha colisionado
    private void OnTriggerEnter(Collider bateryCollision)
    {
        if (!hasCollided && bateryCollision.gameObject.tag == "Player")
        {
            hasCollided = true;
        }
    }

    private void OnTriggerStay(Collider bateryCollision)
    {
        if (bateryCollision.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            AudioManager.Instance.PlaySound(catchItem);
            this.gameObject.SetActive(false);
        }
    }

    //Si ha colisionado, mostrar mensaje y desactivar item
    private void OnGUI()
    {
        if (hasCollided == true)
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "PRESS E");
        }
    }

    //Desactivar GUI si no hay colisión
    private void OnTriggerExit(Collider collision)
    {
        hasCollided = false;
        GUI.enabled = false;
    }
}
