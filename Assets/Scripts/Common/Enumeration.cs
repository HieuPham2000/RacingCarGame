using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Enumeration
{
    // index scene
    public enum SceneBuilderIndex
    {
        Splash = 0,
        MainMenu = 1,
        Credit = 3,
        PlayGame = 2,
        Track01 = 4,
        Track02 = 5,
        Track03 = 6
    }

    // camera mode
    public enum CameraMode
    {
        Normal = 0,
        Far = 1,
        FP = 2
    }

    // Màu xe
    public enum CarBodyColor
    {
        RedBody = 1,
        BlueBody = 2,
        BlackBody = 3
    }

    // Chế độ chơi
    public enum RaceMode
    {
        Race = 0,
        Score = 1,
        Time = 2
    }
}

