using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para mudar de cenas (Menu -> Jogo)

public class gameController : MonoBehaviour
{ 
    // Variável 'static' significa que ela sobrevive entre cenas. 
    // Guarda o nome do carro atual (começa com a Lambo).
    public static string currentSelectCar = "myLamboConvert";

    // Start é chamado antes do primeiro frame (não estamos usando aqui)
    void Start()
    {
        
    }

    // Função pública para fechar o aplicativo
    public void quit()
    {
        // Comando padrão da Unity para fechar o App (funciona no Android/PC)
        Application.Quit ();
    }

    // Função para trocar de fase/cena (ex: ir do Menu para o Main)
    public void changeLevel(string scene)
    {
        // Carrega a cena baseada no nome que passamos (ex: "main")
        SceneManager.LoadScene(scene);
    }
}