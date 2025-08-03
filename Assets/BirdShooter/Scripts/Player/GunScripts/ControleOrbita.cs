using UnityEngine;

public class ApontarFilhoParaMouse : MonoBehaviour
{
    public Transform filhoOrbitante;

    public float angulo;
    public float anguloNoClamp;
    public float anguloMin = -10f;
    public float anguloMax = 190f;

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
        anguloNoClamp = angulo;

        // Limita o ângulo
        angulo = Mathf.Clamp(angulo, anguloMin, anguloMax);

        if (anguloNoClamp < anguloMax && anguloNoClamp > anguloMin)
        {
            transform.rotation = Quaternion.Euler(0, 0, anguloNoClamp);
        }

        // Rotaciona o objeto pai (isso faz o filho girar com ele)
        



    }
}