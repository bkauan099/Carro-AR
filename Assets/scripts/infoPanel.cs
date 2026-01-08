using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoPanel : MonoBehaviour
{
    Animator anim; // Variável para controlar as animações

    // Start é chamado antes do primeiro frame
    void Start()
    {
        // Pega o componente 'Animator' que está neste objeto
        anim = GetComponent<Animator> ();
    }

    // Função para abrir o painel
    public void playSlide()
    {
        // Toca a animação chamada "infoAnim" (Slide entrando)
        anim.Play("infoAnim");
    }

    // Função para fechar o painel
    public void closeSlide()
    {
        // Toca a animação chamada "infoAnimReverse" (Slide saindo)
        anim.Play("infoAnimReverse");
    }
}