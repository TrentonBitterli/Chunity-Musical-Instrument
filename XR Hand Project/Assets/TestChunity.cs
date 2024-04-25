using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Hands.Samples.VisualizerSample;


public class TestChunity : MonoBehaviour
{
    public HandVisualizer handVisualizer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float position = handVisualizer.xAxisPosition;
        float position2 = handVisualizer.xAxisMiddlePosition;
        float position3 = handVisualizer.xAxisRingPosition;
        float position4 = handVisualizer.xAxisLittlePosition;
        float position5 = handVisualizer.xAxisLPosition;
        float position6 = handVisualizer.xAxisLMiddlePosition;
        float position7 = handVisualizer.xAxisLRingPosition;
        float position8 = handVisualizer.xAxisLLittlePosition;
// Debug.Log(" x axis: " + position);
// Scale these values to an appropriate range for frequency and send to chuck.
if(position < 0.008)
{
    Debug.Log("Playing C");
GetComponent<ChuckSubInstance>().RunCode( @"
        523.35 => global float InFreq;
        SawOsc s => dac;
        0.8 => s.gain;
        InFreq => s.freq;
        1000::ms => now;
        0.0 =>s.gain;
        ");
    }

if(position2 <= 0.008)
{
    Debug.Log("Playing B");
GetComponent<ChuckSubInstance>().RunCode( @"
        493.88 => global float InFreq;
        SawOsc i => dac;
        0.8 => i.gain;
        InFreq => i.freq;
        1000::ms => now;
        0.0 => i.gain;
        ");
    }

if(position3 <= 0.008)
{
    Debug.Log("Playing A");
GetComponent<ChuckSubInstance>().RunCode( @"
        440 => global float InFreq;
        SawOsc m => dac;
        0.8 => m.gain;
        InFreq => m.freq;
        1000::ms => now;
        0.0 => m.gain;
        ");
    }

if(position4 <= 0.008)
{
    Debug.Log("Playing G");
GetComponent<ChuckSubInstance>().RunCode( @"
        392 => global float InFreq;
        SawOsc l => dac;
        0.8 => l.gain;
        InFreq => l.freq;
        1000::ms => now;
        0.0 => l.gain;
        ");
    }

if(position5 <= 0.008)
{
    Debug.Log("Playing C");
GetComponent<ChuckSubInstance>().RunCode( @"
        261.63 => global float InFreq;
        SawOsc n => dac;
        0.8 => n.gain;
        InFreq => n.freq;
        1000::ms => now;
        0.0 => n.gain;
        ");
    }
if(position6 <= 0.008)
{
    Debug.Log("Playing D");
GetComponent<ChuckSubInstance>().RunCode( @"
        293.66 => global float InFreq;
        SawOsc o => dac;
        0.8 => o.gain;
        InFreq => o.freq;
        1000::ms => now;
        0.0 => o.gain;
        ");
    }
if(position7 <= 0.008)
{
    Debug.Log("Playing E");
GetComponent<ChuckSubInstance>().RunCode( @"
        329.63 => global float InFreq;
        SawOsc p => dac;
        0.8 => p.gain;
        InFreq => p.freq;
        1000::ms => now;
        0.0 => p.gain;
        ");
    }
if(position8 <= 0.008)
{
    Debug.Log("Playing F");
GetComponent<ChuckSubInstance>().RunCode( @"
        349.23 => global float InFreq;
        SawOsc q => dac;
        0.8 => q.gain;
        InFreq => q.freq;
        1000::ms => now;
        0.0 => q.gain;
        ");
    }
}
}
