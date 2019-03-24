using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    [SerializeField]
    private Transform center;
    private float flySpeed;

    // Start is called before the first frame update
    void Start()
    {
		// Hraði flugurnar í tilviljunarkenndum tölum
        flySpeed = Random.Range(300f, 700f);
    }

    // Update is called once per frame
    void Update()
    {
		// Láta þær snúast í hringi
        transform.RotateAround(center.position, Vector3.up, flySpeed * Time.deltaTime);
    }
}
