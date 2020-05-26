using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public int vidas;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
    }

    // Update is called once per frame
    void Update()
    {
        var txtvidas = GetComponent<UnityEngine.UI.Text>();
        txtvidas.text = "VIDAS\n"+(int)vidas;
    }

    public void sofrerDano()
    {
        vidas-=1;
        if(vidas <=0)
        {
            //GAME OVER
            SceneManager.LoadScene(3);
        }
    }
}
