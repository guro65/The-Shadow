using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move o objeto da direita para a esquerda
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Destrói o objeto se sair da área visível
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}