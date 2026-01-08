using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSelection : MonoBehaviour
{    
    private GameObject[] carList; // Array (lista) para guardar os modelos dos carros
    private int currentCar = 0;   // Índice (número) do carro atual na lista

    // Use isso para inicialização
    void Start()
    { 
        // Conta quantos filhos este objeto tem (quantos carros estão pendurados nele)
        // e cria uma lista desse tamanho.
        carList = new GameObject[transform.childCount];

        // Loop (repetição) para preencher a lista com os carros
        for (int i = 0; i < transform.childCount; ++i)
        {
            // Pega o filho na posição 'i' e guarda na lista
            carList [i] = transform.GetChild (i).gameObject;
        }

        // Primeiro, desativa (esconde) TODOS os carros da lista
        foreach (GameObject gameObj in carList){
            gameObj.SetActive (false);
        }

        // Se existir pelo menos um carro na lista (posição 0)
        if (carList [0])
        {
            // Ativa (mostra) apenas o primeiro carro
            carList [0].SetActive (true);
        }
    }

    // Função chamada pelos botões de seta (Esquerda/Direita)
    public void toggleCars(string direction)
    {
        // Desativa o carro que está aparecendo agora
        carList [currentCar].SetActive (false);

        // Se o botão for "Direita"
        if(direction == "Right")
        {
            currentCar++; // Aumenta o índice (vai para o próximo)
            
            // Se passar do limite da lista, volta para o zero (loop)
            if(currentCar > carList.Length - 1){
                currentCar = 0;
            }
        }
        // Se o botão for "Esquerda"
        else if(direction == "Left")
        {
            currentCar--; // Diminui o índice (vai para o anterior)
            
            // Se for menor que zero, vai para o último da lista
            if(currentCar < 0){
                currentCar = carList.Length - 1;
            }
        }

        // Ativa o NOVO carro selecionado
        carList[currentCar].SetActive(true);

        // Avisa o 'Gerente' (gameController) qual é o nome do novo carro
        gameController.currentSelectCar = carList[currentCar].name;

        // EFEITO ESPECIAL: Cria a fumacinha (partícula) quando troca de carro
        GameObject cloudSystem = Instantiate (Resources.Load ("cloudParticle")) as GameObject;
        ParticleSystem cloudPuff = cloudSystem.GetComponent<ParticleSystem>();
        
        cloudPuff.Play (); // Toca a animação da fumaça
        
        // Define a posição onde a fumaça aparece
        cloudPuff.transform.position = new Vector3(22f,-1.5f,0f);
        
        // Destroi a fumaça depois de 2 segundos para não pesar o jogo
        Destroy (cloudSystem ,2f);
    }
}