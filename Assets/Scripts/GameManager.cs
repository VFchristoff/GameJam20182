using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject Game;

    enum EstadosDoJogo
    {
        Cinematic,
        InGame
    }

	void Start () {
        DontDestroyOnLoad(Game);
	}
	
	void Update () {
		
	}
}
