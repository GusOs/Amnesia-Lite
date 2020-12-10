using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{

    private Collider radioCollision;

    public AudioSource radio;

    private bool RadioPlay;

    // Start is called before the first frame update
    void Start()
    {
        radioCollision = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Play if catch object in scene
    private void OnTriggerEnter(Collider radioCollision)
    {
        if(radioCollision.CompareTag("Player"))
        {
            radio.Play();
            RadioPlay = true;
        }
    }
}
