using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Variáveis públicas
    public float jumpForce = 10f;  // Força do pulo

    // Variáveis privadas
    private Rigidbody2D rb;        // Referência ao Rigidbody2D do jogador

    void Start()
    {
        // Obtém a referência do Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Verifica se a tecla "Space" foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Aplica a força de pulo no eixo Y do Rigidbody2D
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
