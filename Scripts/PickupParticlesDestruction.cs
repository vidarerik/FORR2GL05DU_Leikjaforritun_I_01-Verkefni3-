using UnityEngine;

public class PickupParticlesDestruction : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Eyðileggja pickup agnir eftir 5 sekúndur
        Destroy(gameObject, 5f);
    }
}
