﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMng : MonoBehaviour
{
    // private void Awake()
    // {
        // Screen.sleepTimeout = SleepTimeout.NeverSleep;
        // Screen.SetResolution(1024, 768, true);
    // }

    public void SetGameNo(int gm_no)
    {
        Globals.game_no = gm_no;
    }

    public void Set_Game_Time(int time)
    {
        Globals.game_time_sec = time;
    }
    
    public void Set_Game_Difficult(int val)
    {
        Globals.game_difficult = val;
    }
    
    public void Set_Game_Player(int val)
    {
        Globals.game_player = val;
    }
    
    public void printGlobals(){
        Globals.print_globals();
    }

    public void init_globasl()
    {
        Globals.game_no = 1;
        Globals.game_time_sec = 60;
        Globals.game_difficult = 1;
        Globals.game_player = 1;
    }
    
}
