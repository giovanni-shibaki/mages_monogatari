using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float velocidade;
    public float duracao;
    public int dano;
    public float distancia;
    public LayerMask whatIsSolid;

    public GameObject efeito_destruicao;
    private void Start() {
        Invoke("DestruirProjetil",duracao);
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position , transform.up, distancia);
        if(hitInfo.collider != null)
        {
            if(hitInfo.collider.CompareTag("Inimigo"))
            {
                hitInfo.collider.GetComponent<Inimigo>().hit(dano);
                Debug.Log("Dano inimigo");
                DestuirProjetil();
            }
        }
        transform.Translate(transform.up * velocidade * Time.deltaTime);
    }

    void DestuirProjetil()
    {
        Instantiate(efeito_destruicao, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
