using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos_voltar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void voltarMenu()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
