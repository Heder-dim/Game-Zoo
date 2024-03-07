using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float playerspeed;
    public Animator anim;

    void Update()
    {
        // Verifica se há toques na tela
        if (Input.touchCount > 0)
        {
            // Obtém a posição do primeiro toque
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touchPosition.z = 0f;

            // Calcula a direção do toque em relação à posição atual do jogador
            Vector3 playerDirection = (touchPosition - transform.position).normalized;

            // Atualiza os parâmetros do Animator
            anim.SetFloat("Horizontal", playerDirection.x);
            anim.SetFloat("Vertical", playerDirection.y);
            anim.SetFloat("Speed", playerspeed);

            // Move o jogador na direção do toque
            transform.position = transform.position + playerDirection * playerspeed * Time.deltaTime;
        }
        else
        {
            // Se não houver toque, define a velocidade como zero para parar a animação
            anim.SetFloat("Speed", 0f);
        }
    }
}
