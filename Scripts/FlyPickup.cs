using UnityEngine;

public class FlyPickup : MonoBehaviour
{
    [SerializeField]
    private GameObject pickupPrefab;

    void OnTriggerEnter(Collider other)
    {
        // Ef að tagið er með player á sig
        if (other.CompareTag("Player"))
        {
            // Búa til agnirnar sem koma frá flugunum
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);
            FlySpawner.totalFlies--;
            Destroy(gameObject);
        }
    }
}
