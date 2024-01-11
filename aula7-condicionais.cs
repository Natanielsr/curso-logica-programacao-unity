using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numero = 10;

        // Exemplo de condicional simples
        if (numero > 0)
        {
            print("O número é positivo.");
        }

        // Exemplo de condicional com else if e else
        if (numero > 0)
        {
            print("O número é positivo.");
        }
        else if (numero < 0)
        {
            print("O número é negativo.");
        }
        else
        {
            print("O número é zero.");
        }


        // Exemplo de operadores relacionais
        int idade = 18;

        if (idade >= 18)
        {
            print("Você é maior de idade.");
        }
        else
        {
            print("Você é menor de idade.");
        }

        // Exemplo de operadores aritméticos e lógicos
        int numero = 15;

        if (numero % 2 == 0 && numero > 10)
        {
            print("O número é par e maior que 10.");
        }
        else if (numero % 2 != 0 || numero < 5)
        {
            print("O número é ímpar ou menor que 5.");
        }
        else
        {
            print("O número não atende às condições especificadas.");
        }

    }

}
