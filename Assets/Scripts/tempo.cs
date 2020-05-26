using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempo : MonoBehaviour
{
    private float contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0f;
    }
    
    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        var score = GetComponent<UnityEngine.UI.Text>();
        score.text = "Tempo: "+(int)contador;
    }
}
