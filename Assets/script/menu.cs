using UnityEngine;
using UnityEngine.SceneManagement;  // Necessário para usar o SceneManager

public class SceneChanger : MonoBehaviour
{
    // Nome da cena de destino (modifique conforme necessário)
    public string sceneToLoad = "game";  // Substitua com o nome da sua cena

    // Update é chamado uma vez por frame
    void Update()
    {
        // Verifica se a tecla "Space" foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Carrega a cena
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}