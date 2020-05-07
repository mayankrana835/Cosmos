
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Move : MonoBehaviour { 

    private Rigidbody2d rb;
    private float dirX;
    private float moveSpeed = 10f; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2d>();

    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(dirX, 0f);

    }
}
 