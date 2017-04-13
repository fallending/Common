using UnityEngine;
using System.Collections;

namespace Suite
{
	public class Debuger  {

		static public bool EnableLog = false;

		static public void INFO()
		{
			
		}

		static public void WARN()
		{

		}

		static public void ERROR()
		{

		}



		// 以下需要重构

		static public void Log(object message)
		{
			Log(message,null);
		}
		static public void Log(object message, Object context)
		{
			if(EnableLog)
			{
				Debug.Log(message,context);
			}
		}
		static public void LogError(object message)
		{
			LogError(message,null);
		}
		static public void LogError(object message, Object context)
		{
			if(EnableLog)
			{
				Debug.LogError(message,context);
			}
		}
		static public void LogWarning(object message)
		{
			LogWarning(message,null);
		}
		static public void LogWarning(object message, Object context)
		{
			if(EnableLog)
			{
				Debug.LogWarning(message,context);
			}
		}
	}
}

