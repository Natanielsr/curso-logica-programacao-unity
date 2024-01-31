using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Chamando a função Soma e armazenando o resultado em uma variável.
        int resultadoSoma = Soma(5, 3);

        // Exibindo o resultado.
        print("A soma é: " + resultadoSoma);
   }
   
    void ImprimirMensagem()
    {
        print("Esta é uma mensagem da função!");
    }
    
    // Esta é uma função chamada ImprimirMensagem que tem parâmetro mensagem e não retorna valor.
    void ImprimirMensagem(string mensagem)
    {
        print(mensagem);
    }

    // Esta é uma função chamada Soma, que aceita dois parâmetros inteiros e retorna a soma deles.
    int Soma(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }
}
