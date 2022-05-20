using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerColorList
{
    Red, Blue, Green, Pink, Orange, Yellow, Black, White, Purple, Brown, Cyan, Lime
}

public class PlayerColor
{
    private static List<Color> colors = new List<Color>
    {
        new Color(1f, 0f, 0f),
        new Color(0.1f, 0.1f, 1f),
        new Color(0f, 0.6f, 0f),
        new Color(1f, 0.3f, 0.9f),
        new Color(1f, 0.4f, 0f),
        new Color(1f, 0.9f, 0.1f),
        new Color(0.2f, 0.2f, 0.2f),
        new Color(0.9f, 1f, 1f),
        new Color(0.6f, 0f, 0.6f),
        new Color(0.7f, 1f, 1f),
        new Color(0f, 1f, 1f),
        new Color(0.1f, 1f, 0.1f)
    };

    public static Color GetColor(PlayerColorList colorList)
    {
        return colors[(int)colorList];
    }

    public static Color Red { get { return colors[(int)PlayerColorList.Red]; } }
    public static Color Blue { get { return colors[(int)PlayerColorList.Blue]; } }
    public static Color Green { get { return colors[(int)PlayerColorList.Green]; } }
    public static Color Pink { get { return colors[(int)PlayerColorList.Pink]; } }
    public static Color Orange { get { return colors[(int)PlayerColorList.Orange]; } }
    public static Color Yellow { get { return colors[(int)PlayerColorList.Yellow]; } }
    public static Color Black { get { return colors[(int)PlayerColorList.Black]; } }
    public static Color White { get { return colors[(int)PlayerColorList.White]; } }
    public static Color Purple { get { return colors[(int)PlayerColorList.Purple]; } }
    public static Color Brown { get { return colors[(int)PlayerColorList.Brown]; } }
    public static Color Cyan { get { return colors[(int)PlayerColorList.Cyan]; } }
    public static Color Lime { get { return colors[(int)PlayerColorList.Lime]; } }

}