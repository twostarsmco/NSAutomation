namespace Command
{
    /// <summary>
    /// ID of buttons that this library controls.
    /// Internal byte values correspond to the byte values that Arduino expects.
    /// </summary>
    public enum ButtonID : byte
    {
        None = 255,
        RIGHT = 0,
        LEFT = 1,
        UP = 2,
        DOWN = 3,
        A = 4,
        B = 5,
        X = 6,
        Y = 7,
        R = 8,
        L = 9,
        ZR = 10,
        ZL = 11,
        RCLICK = 14,    // byte values for Sticks are moved to StickID enum
        LCLICK = 15,
        HOME = 16,
        CAPTURE = 17,
        PLUS = 18,
        MINUS = 19
    }

    /// <summary>
    /// State of a button
    /// </summary>
    public enum ButtonState : byte
    {
        PRESS = 0,
        RELEASE = 1
    }

    /// <summary>
    /// ID of sticks that this library controls.
    /// Internal byte values correspond to the byte values that Arduino expects.
    /// </summary>
    public enum StickID : byte
    {
        RSTICK = 12,
        LSTICK = 13,
    }
}
