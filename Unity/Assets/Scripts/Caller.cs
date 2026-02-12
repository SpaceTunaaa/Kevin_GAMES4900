using UnityEngine;

public class Caller : MonoBehaviour
{
    public Receiver receiver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // invoke method from receiver
        receiver.OnCalled();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
