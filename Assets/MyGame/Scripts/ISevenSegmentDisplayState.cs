using UnityEngine;
using System.Collections;

public interface ISevenSegmentDisplayState
{
    // get the Number for the current state 
    public int GetDigit();
    public ISevenSegmentDisplayState CountDown();
    public ISevenSegmentDisplayState CountUp();

}