using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; // Importante: Biblioteca de Realidade Aumentada

public class colourSwitcher : MonoBehaviour {

    // Singleton: Garante que só existe UM colourSwitcher na cena e facilita o acesso
    public static colourSwitcher instance;
    
    public GameObject[] carParts; // Lista das partes do carro que podem mudar de cor
    private GameObject currentTracked; // Guarda qual Imagem Alvo a câmera está vendo agora

    void Awake(){
        // Configuração do Singleton
        if (instance == null) {
            instance = this;
        }
    }

    // Função principal chamada pelos botões de cor na tela
    public void colours(string newcol){
        
        // Descobre qual imagem o Vuforia está rastreando (Achar o "Pai" do carro)
        currentTracked = getCurrentTracked ();
        Debug.Log (currentTracked.name); // Mostra no console para teste

        // 'Switch' funciona como vários 'IFs'. Verifica qual cor foi enviada.
        switch (newcol) {
        case "red":
            // Passa por todas as partes do carro (lataria, portas, etc)
            for (int i = 0; i < carParts.Length; i++) {
                // Procura o carro ativo dentro da imagem rastreada e muda a cor do material para Vermelho
                GameObject.Find(currentTracked.name+"/activeItems/" + gameController.currentSelectCar).GetComponent<colourSwitcher>().carParts[i].GetComponent<Renderer> ().materials[0].color = Color.red;
            }
            break; // Para a execução aqui
        
        case "green":
            // Repete a lógica para Verde
            for (int i = 0; i < carParts.Length; i++) {
                GameObject.Find(currentTracked.name+"/activeItems/" + gameController.currentSelectCar).GetComponent<colourSwitcher>().carParts[i].GetComponent<Renderer> ().materials[0].color = Color.green;
            }
            break;

        case "black":
            // Repete a lógica para Preto
            for (int i = 0; i < carParts.Length; i++) {
                GameObject.Find(currentTracked.name+"/activeItems/" + gameController.currentSelectCar).GetComponent<colourSwitcher>().carParts[i].GetComponent<Renderer> ().materials[0].color = Color.black;
            }
            break;

        case "blue":
            // Repete a lógica para Azul
            for (int i = 0; i < carParts.Length; i++) {
                GameObject.Find(currentTracked.name+"/activeItems/" + gameController.currentSelectCar).GetComponent<colourSwitcher>().carParts[i].GetComponent<Renderer> ().materials[0].color = Color.blue;
            }
            break;

        case "magenta":
            // Repete a lógica para Magenta
            for (int i = 0; i < carParts.Length; i++) {
                GameObject.Find(currentTracked.name+"/activeItems/" + gameController.currentSelectCar).GetComponent<colourSwitcher>().carParts[i].GetComponent<Renderer> ().materials[0].color = Color.magenta;
            }
            break;

        case "white":
            // Repete a lógica para Branco
            for (int i = 0; i < carParts.Length; i++) {
                GameObject.Find(currentTracked.name+"/activeItems/" + gameController.currentSelectCar).GetComponent<colourSwitcher>().carParts[i].GetComponent<Renderer> ().materials[0].color = Color.white;
            }
            break;

        case "grey":
            // Repete a lógica para Cinza
            for (int i = 0; i < carParts.Length; i++) {
                GameObject.Find(currentTracked.name+"/activeItems/" + gameController.currentSelectCar).GetComponent<colourSwitcher>().carParts[i].GetComponent<Renderer> ().materials[0].color = Color.grey;
            }
            break;

        case "yellow":
            // Repete a lógica para Amarelo
            for (int i = 0; i < carParts.Length; i++) {
                GameObject.Find(currentTracked.name+"/activeItems/" + gameController.currentSelectCar).GetComponent<colourSwitcher>().carParts[i].GetComponent<Renderer> ().materials[0].color = Color.yellow;
            }
            break;

        default:
            break;
        }
    }

    // Função ESPECIAL do Vuforia: Descobre onde está o carro no mundo real
    public GameObject getCurrentTracked(){
        // Pega o 'Gerente de Estados' do Vuforia
        StateManager sm = TrackerManager.Instance.GetStateManager ();

        // Pergunta ao Vuforia: "O que você está rastreando agora?"
        // Retorna uma lista de objetos ativos (imagens encontradas pela câmera)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();

        // Varre a lista (geralmente só tem 1 imagem alvo por vez)
        foreach (TrackableBehaviour tb in activeTrackables) {
            currentTracked = tb.gameObject; // Achei! Esse é o objeto ImageTarget atual
        }
        return currentTracked; // Devolve o objeto encontrado
    }
}