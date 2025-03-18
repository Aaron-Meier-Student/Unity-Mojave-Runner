using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Parallax.Layer layer;
    public float endRange = -12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Parallax.GetSpeed(layer) * Time.deltaTime;

        if (transform.position.x <= endRange){
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health.TryDamage(collision.gameObject, 1);
    }
}
