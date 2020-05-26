using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidade;
    public float duracao;

    public GameObject efeito_destruicao;
    private void Start() {
        Invoke("DestuirProjetil", duracao);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * velocidade * Time.deltaTime);
    }

    void DestuirProjetil()
    {
        Instantiate(efeito_destruicao, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
