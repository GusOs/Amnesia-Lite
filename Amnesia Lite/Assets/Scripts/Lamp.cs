using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    private bool isEnabled;

    public new GameObject light;

    AudioSource switchSound;

    private Collider lampCollision;


    // Start is called before the first frame update
    void Start()
    {
        lampCollision = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision lampCollision)
    {
        if (Input.GetKey("e"))
        {
            isEnabled = !isEnabled;

            light.SetActive(isEnabled);

            if (switchSound != null)
                switchSound.Play();
        }
    }
}
