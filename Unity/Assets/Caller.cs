using UnityEngine;

public class Caller : MonoBehaviour
{
    [SerializeField] private Receiver receiver;

    private void Start()
    {
        Debug.Log("Hello Friend");

        receiver.OnCalled();
    }
}