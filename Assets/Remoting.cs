using System.Collections;

using UnityEngine;

using UnityEngine.XR;

using UnityEngine.XR.WSA;



public class Remoting : MonoBehaviour

{

    private string IP = "18.21.163.73";


    private bool connected;



    private void Start()

    {

        StartCoroutine(LoadingWindowsMrWrapper());

    }



    private IEnumerator LoadingWindowsMrWrapper()

    {

        yield return new WaitForSeconds(1);

        Connect();

    }



    public void Connect()

    {

        if (HolographicRemoting.ConnectionState != HolographicStreamerConnectionState.Connected)

        {
            Debug.Log("Inside");
            StartCoroutine(LoadDevice("WindowsMR"));

        }

    }



    IEnumerator LoadDevice(string newDevice)

    {

        yield return null;

        XRSettings.LoadDeviceByName(newDevice);

        yield return null;

        XRSettings.enabled = true;

        yield return new WaitForSeconds(1);

        HolographicRemoting.Connect(IP);

    }



    private void OnDisable()

    {

        if (HolographicRemoting.ConnectionState == HolographicStreamerConnectionState.Connected)

        {

            HolographicRemoting.Disconnect();

        }

        else if (HolographicRemoting.ConnectionState == HolographicStreamerConnectionState.Connecting)

        {

            HolographicRemoting.Disconnect();

        }



    }

}