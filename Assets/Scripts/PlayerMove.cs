using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private GameManager gameManager;
	private Rigidbody rb;
	public float forward = 500f;
	public float side = 20f;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello the world!!");
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forward * Time.deltaTime);
        if (Input.GetKey("d"))
        	rb.AddForce(side*Time.deltaTime, 0, 0, ForceMode.VelocityChange);   
        if (Input.GetKey("a"))
        	rb.AddForce(-side*Time.deltaTime,0, 0, ForceMode.VelocityChange);  
        if (rb.position.y < 0.0f)
        {
            this.enabled = false;
            gameManager.EndGame();
        }
    }
}
