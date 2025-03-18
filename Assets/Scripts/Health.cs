using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 3;

    public void Damage(int damage)
    {
        health -= damage;
        GameFeel.AddCameraShake(0.1f);
        if (health <= 0)
        {
            GameManager.instance.Restart();
        }
    }

    public static void TryDamage(GameObject target, int damage)
    {
        Health thealth = target.GetComponent<Health>();

        if (thealth)
        {
            thealth.Damage(damage);
        }
    }
}
