using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{
    public float offset;
    public GameObject bola_de_fogo;
    public Transform ponto_de_tiro;
    private float cooldown;
    public float tempoInicialTiros;
    private bool m_FacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if(cooldown <=0 )
        {
            Vector3 posicao = transform.position;
            if(Input.GetButtonDown("e")) // Tiro para a direita
            {
                Flip(true);
                Instantiate(bola_de_fogo, ponto_de_tiro.position, Quaternion.Euler(0f,0f,posicao.z-45f));
                cooldown = tempoInicialTiros;
            }
            if(Input.GetButtonDown("q")) // Tiro para a esquerda
            {
                Flip(false);
                Instantiate(bola_de_fogo, ponto_de_tiro.position, Quaternion.Euler(0f,0f,posicao.z+45f));
                cooldown = tempoInicialTiros;
            }
        }
        else
        {
            cooldown -= Time.deltaTime;
        }

        
    }

    private void Flip(bool direcao)
	{
		// Switch the way the player is labelled as facing.
		m_FacingRight = !m_FacingRight;

		// Multiply the player's x local scale by -1.
        GameObject corpo = GameObject.Find("Sepiroth");
		Vector3 theScale = corpo.transform.localScale;
        if(direcao && theScale.x != 1) // Se quer atirar para a direita verifica se já está olhando para a direita para não ter que virar o corpo para a direção errada
        {
            theScale.x *= -1;
		    corpo.transform.localScale = theScale;
        }
        if(!direcao && theScale.x != -1) // Se quer atirar para a esquerda verifica se já está olhando para a esquerda para não ter que virar o corpo para a direção errada
        {
            theScale.x *= -1;
		    corpo.transform.localScale = theScale;
        }
		
	}
}
