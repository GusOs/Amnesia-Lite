using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodDoor : MonoBehaviour
{

    private Collider doorCollision;

    private bool hasCollided = false;

    public Sound blood;

    public Batery batery;

    // Start is called before the first frame update
    void Start()
    {
        doorCollision = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider doorCollision)
    {
        if (!hasCollided && doorCollision.gameObject.tag == "Player")
        {
            hasCollided = true;
        }
    }

    private void OnTriggerStay(Collider doorCollision)
    {
        // And all batery hierarchy false
        if (doorCollision.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySound(blood);
            // Material blood
        }
    }
}
