

//script que faz o personagem se mover
using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    //referencia ao character controller

    private CharacterController controller;


   void Start()
    {
        controller = GetComponent<CharacterController>();//Vai procurar o componente CharacterController no objeto que esse script está anexado


    }


//metodo de update que é executado a cada frame
    // Update is called once per frame
    void Update()
    {
        //ver se está clicando as teclas
        float horizontal = Input.GetAxis("Horizontal"); //pega o valor do eixo horizontal
        float vertical = Input.GetAxis("Vertical"); //pega o valor na vertical


        
        //mover o personagem
        Vector3 movimento = new Vector3(horizontal, -9.81f, vertical); // -9.81 é a gravidade
        controller.Move(movimento * Time.deltaTime * 5);// Time.detalTime = para ficar consistente em qualquer taxa de quadro
        //para carregar na taxa de quadro que o jogo está rodando



    }
}
