using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fim_de_jogo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider.tag == "Player")
        {
            Debug.Log("Você passou esta fase. Parabens!");
            // Fim de jogo
            SceneManager.LoadScene("Creditos");
        }
    }
}
