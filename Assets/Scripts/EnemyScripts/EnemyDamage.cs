using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnCollisionEnter2D(Collision2D other) {
        IDamageable damageable = other.gameObject.GetComponent<IDamageable>();
        damageable?.TakeDamage(damageAmount);
    }
}
