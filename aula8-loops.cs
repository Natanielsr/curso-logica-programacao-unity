using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    //loop for
    for (int i = 0; i < 5; i++)	{
      //código a ser repetido
      print(i);
    }

    //loop while
    int contador = 0;
    while (contador < 5)
    {
      //código a ser repetido
      print(contador);
      contador++;
    }

    //loop do while
    contador = 0;
    do
    {
      //código a ser repetido
      print(contador);
      contador++;
    } while (contador < 5);
  }
}
