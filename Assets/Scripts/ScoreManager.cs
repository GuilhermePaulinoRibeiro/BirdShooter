using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text pontos;
    float pontosValue = 0;
    void Start()
    {
        pontosValue = 0;
        pontos.text = $"Pontos: {pontosValue}";

    }

    // Update is called once per frame
    void Update()
    {
    }

    [ContextMenu("Adicionar Pontos")]
    public void AdicionarPonto()
    {
        pontosValue += 1;
        pontos.text = $"Pontos: {pontosValue}";
    }
    
}
