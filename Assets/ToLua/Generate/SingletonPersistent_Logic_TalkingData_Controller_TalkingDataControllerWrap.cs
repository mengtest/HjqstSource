﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SingletonPersistent_Logic_TalkingData_Controller_TalkingDataControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SingletonPersistent<Logic.TalkingData.Controller.TalkingDataController>), typeof(System.Object), "SingletonPersistent_Logic_TalkingData_Controller_TalkingDataController");
		L.RegFunction("New", _CreateSingletonPersistent_Logic_TalkingData_Controller_TalkingDataController);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("instance", get_instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSingletonPersistent_Logic_TalkingData_Controller_TalkingDataController(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SingletonPersistent<Logic.TalkingData.Controller.TalkingDataController> obj = new SingletonPersistent<Logic.TalkingData.Controller.TalkingDataController>();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SingletonPersistent<Logic.TalkingData.Controller.TalkingDataController>.New");
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

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, SingletonPersistent<Logic.TalkingData.Controller.TalkingDataController>.instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
