using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject projectPrefab; // Prefab do projétil
    public float attackRate = 4f;    // Taxa de ataque

    void Start()
    {
        // Repetir ataques na taxa definida
        InvokeRepeating(nameof(Attack), attackRate, attackRate);
    }

    void Attack()
    {
        if (projectPrefab == null)
        {
            Debug.LogError("Prefab do projétil não configurado!");
            return;
        }

        // Obtém a posição do mouse no mundo
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Garante que a posição do mouse esteja no plano 2D

        // Calcula a direção do disparo
        Vector2 attackDirection = (mousePosition - transform.position).normalized;

        // Instancia o projétil
        GameObject projectile = Instantiate(projectPrefab, transform.position, Quaternion.identity);

        // Configura a direção no script do projétil
        ProjectBehavior projBehavior = projectile.GetComponent<ProjectBehavior>();
        if (projBehavior != null)
        {
            projBehavior.SetDirection(attackDirection);
        }

        Destroy(projectile, 2f); // Destroi o projétil após 2 segundos
    }
}
