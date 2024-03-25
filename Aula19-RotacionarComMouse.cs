using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionarComMouse : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Cria um raio a partir da posição do mouse na tela
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Define as camadas que o raycast deve detectar
        int layerMask = 1 << LayerMask.NameToLayer("Terreno");

        // Verifica se o raio colide com algum objeto na cena
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            // Verifica se o objeto atingido é o chão
            if (hit.collider.CompareTag("Terreno"))
            {
                // Obtém a posição de colisão do raio com o chão
                Vector3 posicaoAlvo = hit.point;

                // Calcula a direção do vetor entre a posição do objeto e a posição de colisão
                Vector3 direcao = posicaoAlvo - transform.position;

                // Ignora a rotação nos eixos X e Z
                direcao.y = 0;

                // Rotaciona o objeto apenas no eixo Y para olhar na direção da posição de colisão
                transform.rotation = Quaternion.LookRotation(direcao);
            }
        }
    }
}
