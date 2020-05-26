using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public AudioSource scoreup;
    // Start is called before the first frame update
    void Start()
    {
        scoreup = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy() {
        scoreup.Play();
        Debug.Log("Moeda destruida");
    }
}
