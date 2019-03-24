using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject flyPrefab;

    [SerializeField]
    private int totalFlyMinimum = 12;

    [SerializeField]
    private float spawnArea = 25f;

    public static int totalFlies;

    // Start is called before the first frame update
    void Start()
    {
        totalFlies = 0;

    }

    // Update is called once per frame
    void Update()
    {
        // Á meðan að heildarfjöldi fluganna sé minna en lágmarkið
        while (totalFlies < totalFlyMinimum)
        {
            totalFlies++;

            // Bua til tilvijunarkennda staðsetningu fyrir flugur
            float positionX = Random.Range(-spawnArea, spawnArea);
            float positionZ = Random.Range(-spawnArea, spawnArea);

            Vector3 flyPosition = new Vector3(positionX, 2f, positionZ);

            // Búa til nýja flugu
            Instantiate(flyPrefab, flyPosition, Quaternion.identity);
        }
    }
}
