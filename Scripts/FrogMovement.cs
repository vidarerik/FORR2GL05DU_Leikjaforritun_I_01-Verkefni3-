using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    private float horizontalMovement;
    private float verticalMovement;
    private Vector3 desiredDirection;

    private Animator anim;

    private Rigidbody rb;

    [SerializeField] private float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Ná i componenta fyrir froskinn
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.SetBool("IsIdle", true);
    }

    // Update is called once per frame
    void Update()
    {
        // Safna inntakinu frá leikmanni
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
        // Reikna viðeigandi stefnu fyrir froski
        desiredDirection = new Vector3(horizontalMovement, 0, verticalMovement);
    }
    void FixedUpdate()
    {
        // f viðkomandi átt er núll ...
        if (desiredDirection == Vector3.zero)
        {
            // stilltu þá hreyfimyndina í Idle
            anim.SetBool("IsIdle", true);
        }
        else
        {
            // Reiknaðu snúninginn sem froskurinn átti að snúa til að líta í viðkomandi átt
            Quaternion targetRotation = Quaternion.LookRotation(desiredDirection, Vector3.up);

            // Reiknaðu annan snúning sem mun snúa froskinn frá núverandi snúningi
            Quaternion newRotation = Quaternion.Lerp(rb.rotation, targetRotation, turnSpeed * Time.fixedDeltaTime);

            // Snúa froskinn okkar
            rb.MoveRotation(targetRotation);
            // Setja hann í hreyfingu
            anim.SetBool("IsIdle", false);
        }
    }
}
