﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Common_UI_Components_OnInitCompleteWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Common.UI.Components.OnInitComplete), typeof(UnityEngine.Events.UnityEvent));
		L.RegFunction("New", _CreateCommon_UI_Components_OnInitComplete);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateCommon_UI_Components_OnInitComplete(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Common.UI.Components.OnInitComplete obj = new Common.UI.Components.OnInitComplete();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Common.UI.Components.OnInitComplete.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}
}
