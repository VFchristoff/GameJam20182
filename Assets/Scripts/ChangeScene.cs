using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void StartCreditos()
    {
        SceneManager.LoadScene("Credits");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("1_Quintal");
    }

    public void Cozinha()
    {
        SceneManager.LoadScene("2_Cozinha");
    }

    public void Sala()
    {
        SceneManager.LoadScene("3_Sala");
    }

    public void Porta()
    {
        SceneManager.LoadScene("4_Porta");
    }

    public void Corredor()
    {
        SceneManager.LoadScene("5_Corredor");
    }

    public void Quarto()
    {
        SceneManager.LoadScene("6_Quarto");
    }

    public void Banheiro()
    {
        SceneManager.LoadScene("7_Banheiro");
    }

    public void Jardim()
    {
        SceneManager.LoadScene("8_Jardim");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }


    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}