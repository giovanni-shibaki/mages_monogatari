using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    static int score;
    public AudioSource scoreup;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreup = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var sc = GetComponent<UnityEngine.UI.Text>();
        sc.text = "Score : " + score;
    }

    public void coletaMoeda(int valor)
    {
        score+=valor;
        scoreup.Play();
    }
}
