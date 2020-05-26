using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public int vida;
    public AudioSource scoreup;
    public GameObject sc;
    public GameObject vidas;

    // Update is called once per frame
    void Update()
    {
        if(vida<=0)
        {
            //Game over
        }
    }

    public void scoreUp()
    {
        scoreup.Play();
    }

    private void Start() {
        scoreup = GetComponent<AudioSource>();
        sc = GameObject.Find("score");
        vidas = GameObject.Find("vidas");
    }

    public void sofrerDanoD()
    {
        vida-=1;
        transform.Translate(Vector3.right*3f); //Move o jogador um pouco para o lado no qual sofreu dano
        Debug.Log("Player sofreu dano");
        vidas.GetComponent<Vidas>().sofrerDano();
        //dano.Play();
    }
    public void sofrerDanoE()
    {
        vida-=1;
        transform.Translate(Vector3.left*3f); //Move o jogador um pouco para o lado no qual sofreu dano
        Debug.Log("Player sofreu dano");
        vidas.GetComponent<Vidas>().sofrerDano();
        //dano.Play();
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Bateu em alguma coisa");
        Debug.Log(other.transform);

        if(other.collider.tag == "Moeda1")
        {
            sc.GetComponent<Score>().coletaMoeda(1);
            Destroy(other.gameObject);
        }
        if(other.collider.tag == "Moeda5")
        {
            sc.GetComponent<Score>().coletaMoeda(5);
            Destroy(other.gameObject);
        }
        if(other.collider.tag == "Moeda10")
        {
            sc.GetComponent<Score>().coletaMoeda(10);
            Destroy(other.gameObject);
        }
        if(other.collider.tag == "Moeda20")
        {
            sc.GetComponent<Score>().coletaMoeda(20);
            Destroy(other.gameObject);
        }
        if(other.collider.tag == "Moeda50")
        {
            sc.GetComponent<Score>().coletaMoeda(50);
            Destroy(other.gameObject);
        }
    }
}
