using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Vari�veis p�blicas
    public float jumpForce = 10f;  // For�a do pulo

    // Vari�veis privadas
    private Rigidbody2D rb;        // Refer�ncia ao Rigidbody2D do jogador

    void Start()
    {
        // Obt�m a refer�ncia do Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Verifica se a tecla "Space" foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Aplica a for�a de pulo no eixo Y do Rigidbody2D
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
