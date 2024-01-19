using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    int diaDaSemana = 3;
    switch (diaDaSemana)
    {
      case 1:
        print("Segunda-feira");
        break;
      case 2:
        print("Terça-feira");
        break;
      case 3:
        print("Quarta-feira");
        break;
      case 4:
        print("Quinta-feira");
        break;
      case 5:
        print("Sexta-feira");
        break;
      case 6:
        print("Sábado");
        break;
      case 7:
        print("Domingo");
        break;
      default:
        print("Valor inválido");
        break;
    }
  }
}
