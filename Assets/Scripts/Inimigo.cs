using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int vida;
    public GameObject efeito_morte;
    public int pontos; //Quantos pontos determinados inimigos valem ao serem mortos

    public float velocidade;
    public string nome_waypointEsquerda,nome_waypointDireita;
    Transform waypointEsquerda,waypointDireita;
    Vector3 localScale;
    bool mov_direita = true;
    Rigidbody2D corpo;   

    public GameObject sc; //Para aumentar o score do jogador


    private void Start() {
        localScale = transform.localScale;
        corpo = GetComponent<Rigidbody2D>();
        waypointDireita = GameObject.Find(nome_waypointDireita).GetComponent<Transform>();
        waypointEsquerda = GameObject.Find(nome_waypointEsquerda).GetComponent<Transform>();

        sc = GameObject.Find("score");
    }

    private void Update()
    {
        //movimentação

        if(transform.position.x > waypointDireita.position.x)
        {
            mov_direita = false;
        }
        if(transform.position.x < waypointEsquerda.position.x)
        {
            mov_direita = true;
        }
        
        if(mov_direita)
        {
            ir_direita();
        }
        else
        {
            ir_esquerda();
        }

        //movimentação

        //Dano ao jogar ao encostar

        RaycastHit2D hitInfoD = Physics2D.Raycast(new Vector2(transform.position.x+1.7f,transform.position.y) , transform.up, 1.5f);
        RaycastHit2D hitInfoE = Physics2D.Raycast(new Vector2(transform.position.x-1.7f,transform.position.y) , transform.up, 1.5f);
        if(hitInfoD.collider != null) //Inimigo deu dano ao player pelo seu lado direito
        {
            Debug.Log("Entrou no collider "+hitInfoD.collider.name+" "+transform.name);
            if(hitInfoD.collider.CompareTag("Player"))
            {
                hitInfoD.collider.GetComponent<Jogador>().sofrerDanoD();
                Debug.Log("Dano ao player");
            }
        }
        if(hitInfoE.collider != null) //Inimigo deu dano ao player pelo seu lado esquerdo
        {
            Debug.Log("Entrou no collider "+hitInfoE.collider.name+" "+transform.name);
            if(hitInfoE.collider.CompareTag("Player"))
            {
                hitInfoE.collider.GetComponent<Jogador>().sofrerDanoE();
                Debug.Log("Dano ao player");
            }
        }

        //Dano ao jogador ao encostar

        if(vida<=0)
        {
            //Instantiate(efeito_morte, transform.position, Quaternion.identity);
            Destroy(gameObject);
            sc.GetComponent<Score>().coletaMoeda(pontos); // Adiciona x pontos ao score do jogador
        }
    }


    public void hit(int dano) {
        vida -= dano;
    }
    // Start is called before the first frame update


    void ir_direita()
    {
        mov_direita = true;
        localScale.x = 20;
        transform.localScale = localScale;
        corpo.velocity = new Vector2(localScale.x * velocidade,corpo.velocity.y);
    }
    void ir_esquerda()
    {
        mov_direita = false;
        localScale.x = -20;
        transform.localScale = localScale;
        corpo.velocity = new Vector2(localScale.x * velocidade,corpo.velocity.y);
    }
}
