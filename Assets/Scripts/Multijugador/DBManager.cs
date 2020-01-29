using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager
{
    public static string nickname;

    public static bool LoggedIn { get { return nickname != null; } }

    public static void LogOut()
    {
        nickname = null;
    }
}
