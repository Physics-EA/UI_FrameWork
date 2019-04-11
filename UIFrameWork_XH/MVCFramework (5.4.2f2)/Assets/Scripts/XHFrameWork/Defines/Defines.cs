using UnityEngine;
using System.Collections;

namespace XHFrameWork
{
    public delegate void StateChangeEvent(Object ui, EnumObjectState newState, EnumObjectState oldState);

    public enum EnumObjectState
    {
        None,
        Initial,
        Loading,
        Ready,
        Disabled,
        Closing
    }

    public enum EnumUIType
    {
        None = -1,
        TestOne = 0,
        TestTwo = 1,
    }


    public class Defines
    {


    }
}
