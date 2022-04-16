#define XBOX
#define PS4
using UnityEngine;

public static class InputManager
{
    
#if XBOX
    public static XboxController[] xboxControllers;
    public static XboxController p1Xbox;
    public static XboxController p2Xbox;
    public static XboxController p3Xbox;
    public static XboxController p4Xbox;
    public static XboxController p5Xbox;
    public static XboxController p6Xbox;
    public static XboxController p7Xbox;
    public static XboxController p8Xbox;
#endif

#if PS4
    public static PS4Controller[] ps4Controllers;
    public static PS4Controller p1PS4;
    public static PS4Controller p2PS4;
    public static PS4Controller p3PS4;
    public static PS4Controller p4PS4;
#endif
    public static void Initialize()
    {
#if XBOX

        xboxControllers = new XboxController[8];
        for (int i = 0; i < 8; ++i)
            xboxControllers[i] = new XboxController(i);
        p1Xbox = xboxControllers[0];
        p2Xbox = xboxControllers[1];
        p3Xbox = xboxControllers[2];
        p4Xbox = xboxControllers[3];
        p5Xbox = xboxControllers[4];
        p6Xbox = xboxControllers[5];
        p7Xbox = xboxControllers[6];
        p8Xbox = xboxControllers[7];
#endif
#if PS4

        ps4Controllers = new PS4Controller[4];
        for (int i = 0; i < 4; ++i)
            ps4Controllers[i] = new PS4Controller(i);
        

        p1PS4 = ps4Controllers[0];
        p2PS4 = ps4Controllers[1];
        p3PS4 = ps4Controllers[2];
        p4PS4 = ps4Controllers[3];
#endif
    }
    public static void UpdateControllers()
    {
#if XBOX
        for (int i = 0; i < xboxControllers.Length; ++i)
        {
            for (int j = 0; j < xboxControllers[i].buttons.Length; ++j)
            {
                xboxControllers[i].buttons[j].Refresh();
            }
            xboxControllers[i].RefreshAxisValues();
        }
#endif
#if PS4
        for (int i = 0; i < ps4Controllers.Length; ++i)
        {
            for (int j = 0; j < ps4Controllers[i].buttons.Length; ++j)
            {
                ps4Controllers[i].buttons[j].Refresh();
            }
            ps4Controllers[i].RefreshAxisValues();
        }
#endif
    }
    
}
