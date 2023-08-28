using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public struct InputNetwork :INetworkInput
{
    public Vector2 Direction;
}
public class CollectInputHandleNetwork : MonoBehaviour
{
    Vector2 InputData;
    private void Update()
    {
        InputData = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    public InputNetwork GetInputNetwork()
    {
        InputNetwork inputNetwork = new InputNetwork();
        inputNetwork.Direction = InputData;
        return inputNetwork;
    }    
}
