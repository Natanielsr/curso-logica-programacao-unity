using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    // Declarando um array de strings para representar o inventário
    string[] inventario = new string[5]; // Você pode ajustar o tamanho conforme necessário
    
    // Adicionando itens ao inventário
    inventario[0] = “Espada”;
    inventario[1] = “Poção de Cura”;
    inventario[2] = “Armadura de Couro”;
    inventario[3] = “Varinha Mágica”;
    inventario[4] = “Poção de invisibilidade”;
    
    // Acessando e exibindo valores do array
    print("Elemento no índice 0: " + inventario[0]);
    print("Elemento no índice 1: " + inventario[1]);
    // ...
    
    // Você também pode usar um loop para percorrer os elementos do array
    //Array.Length é uma propriedade que retorna o número total de elementos em um array 
    for (int i = 0; i < inventario.Length; i++)
    {
        print("Elemento no índice " + i + ": " + inventario[i]);
    }
  }
}
