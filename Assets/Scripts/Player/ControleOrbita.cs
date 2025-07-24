using UnityEngine;

public class ApontarFilhoParaMouse : MonoBehaviour
{
    public Transform filhoOrbitante;

    public float angulo;

    Vector3 mousePos, direcao;

    void Update()
    {
        // Posição do mouse no mundo
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        // Direção do pai até o mouse
        direcao = mousePos - transform.position;

        // Calcula o ângulo
        angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;

        if (angulo > 0)
        {
            // Rotaciona o objeto pai (isso faz o filho girar com ele)
            transform.rotation = Quaternion.Euler(0, 0, angulo);
        }

    }
}