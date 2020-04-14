using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public int vida;

    // Update is called once per frame
    void Update()
    {
        if(vida<=0)
        {
            //Game over
        }
    }

    public void sofrerDano()
    {
        vida-=1;
        Debug.Log("Player sofreu dano");
    }
}
