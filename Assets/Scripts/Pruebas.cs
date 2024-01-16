using UnityEngine;

public class Pruebas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector3(0,0,0), new Vector3(3,0,0), Color.yellow);
        Debug.DrawRay(new Vector3(0,0,0), new Vector3(10,10,0), Color.red);
        Debug.DrawRay(transform.position, transform.up, Color.red);
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
        Debug.DrawRay(transform.position, transform.right, Color.green);
    }
}
