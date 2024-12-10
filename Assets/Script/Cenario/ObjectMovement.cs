using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move o objeto da direita para a esquerda
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Destr�i o objeto se sair da �rea vis�vel
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}