using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.ComponentModel;
using System.Text;
using Sanford;
using Sanford.Multimedia.Midi;
using Sanford.Multimedia.Midi.UI;
using System.Threading;

public class playNote : MonoBehaviour {

    public static OutputDevice outDevice;

    public static int outDeviceID = 0;

    public void playChord(int noteCode) {
        outDevice.Send(new ChannelMessage(ChannelCommand.NoteOn, 0, noteCode, 127));
    }
    // Use this for initialization
    void Start () {
        doThings();
    }

    // Update is called once per frame
    void Update () {

        /*if (Input.GetKeyDown(KeyCode.A))
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.NoteOn, 0, noteCode, 127));
        }
        else if (Input.GetKeyUp(KeyCode.A)) {
            outDevice.Send(new ChannelMessage(ChannelCommand.NoteOff, 0, noteCode, 127));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.NoteOn, 0, noteCode+5, 127));
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            outDevice.Send(new ChannelMessage(ChannelCommand.NoteOff, 0, noteCode+5, 127));
        }*/

    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(2f);
        print(Time.time);
    }

    private static void doThings()
    {
        if (OutputDevice.DeviceCount == 0)
        {
            Debug.Log("No MIDI output devices available.");

        }
        else
        {
           outDevice = new OutputDevice(outDeviceID);
        }
    }
}
