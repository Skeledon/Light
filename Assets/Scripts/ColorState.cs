using UnityEngine;

public class ColorState
{
    public enum State { Red = 0, Green, Blue, Cyan, Yellow, Magenta, White, Black }
    public State CurrentState;

    public static Color[] StateColors = { Color.red, Color.green, Color.blue, Color.cyan, Color.yellow, Color.magenta, Color.white, Color.black };
}
