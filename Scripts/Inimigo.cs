using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int vida;
    public GameObject efeito_morte;


    public float velocidade;
    public string nome_waypointEsquerda,nome_waypointDireita;
    Transform waypointEsquerda,waypointDireita;
    Vector3 localScale;
    bool mov_direita = true;
    Rigidbody2D corpo;

    private void Start() {
        localScale = transform.localScale;
        corpo = GetComponent<Rigidbody2D>();
        waypointDireita = GameObject.Find(nome_waypointDireita).GetComponent<Transform>();
        waypointEsquerda = GameObject.Find(nome_waypointEsquerda).GetComponent<Transform>();
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

        /*RaycastHit2D hitInfo = Physics2D.Raycast(transform.position , transform.up, 5f);
        if(hitInfo.collider != null)
        {
            if(hitInfo.collider.CompareTag("Player"))
            {
                hitInfo.collider.GetComponent<Jogador>().sofrerDano();
            }
        }*/

        if(vida<=0)
        {
            //Instantiate(efeito_morte, transform.position, Quaternion.identity);
            Destroy(gameObject);
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
