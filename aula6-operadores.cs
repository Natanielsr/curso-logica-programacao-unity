using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Operadores Aritméticos

        int a = 10;
        int b = 3;

        int soma = a + b;  // resultado será 13
        int subtracao = a - b;  // resultado será 7
        int multiplicacao = a * b;  // resultado será 30
        int divisao = a / b; resultado será   // 3
        int modulo = a % b; resultado será   // 1

        //Operadores Relacionais

        int x = 5;
        int y = 10;

        bool igual = x == y;  // false
        bool diferente = x != y;  // true
        bool maiorQue = x > y;  // false
        bool menorQue = x < y;  // true
        bool maiorOuIgual = x >= y;  // false
        bool menorOuIgual = x <= y;  // true

        //Operadores Lógicos
        bool condição1 = true;
        bool condição2 = false;

        bool resultadoE = condição1 && condição2;  // false
        bool resultadoOU = condição1 || condição2;  // true
        bool resultadoNOT = !condição1;  // false

    }

}
