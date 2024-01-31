using UnityEngine;

public class Player : MonoBehaviour
{
    public string nomeDoPlayer = "Player1";

    public void MoverPlayer(string direcao)
    {
        print("O player " + nomeDoPlayer + " se movimentou para Direcao " + direcao);
    }
}
