using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Porta1 : MonoBehaviour {

	void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Cozinha");
    }


    void Update () {

    }
}
