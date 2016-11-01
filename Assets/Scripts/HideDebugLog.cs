//  HideDebugLog.cs
//  http://kan-kikuchi.hatenablog.com/entry/HideDebugLog
//
//  Created by kan kikuchi on 2015.11.02.

using System;
using UnityEngine;

#if !SHOW_DEBUG
public static class Debug{
	public static void Assert(bool condition){}
	public static void Assert(bool condition, string message){}
	public static void Assert(bool condition, string format, params object[] args){}

	public static void Break(){}

	public static void ClearDeveloperConsole(){}

	public static void DrawLine(Vector3 start, Vector3 end){}
	public static void DrawLine(Vector3 start, Vector3 end, Color color){}
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration){}
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest){}

	public static void DrawRay (Vector3 start, Vector3 dir){}  
	public static void DrawRay (Vector3 start, Vector3 dir, Color color){}
	public static void DrawRay (Vector3 start, Vector3 dir, Color color, float duration){}
	public static void DrawRay (Vector3 start, Vector3 dir, Color color, float duration, bool depthTest){}

	public static void Log(object message, UnityEngine.Object context = null){}
	public static void LogFormat(string format, params object[] args){}
	public static void LogFormat(UnityEngine.Object context, string format, params object[] args){}

	public static void LogError(object message, UnityEngine.Object context = null){}
	public static void LogErrorFormat(string format, params object[] args){}
	public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args){}

	public static void LogException(Exception exception){}
	public static void LogException(Exception exception, UnityEngine.Object context){}

	public static void LogWarning(object message, UnityEngine.Object context = null){}
	public static void LogWarningFormat(string format, params object[] args){}
	public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args){}
}
#endif