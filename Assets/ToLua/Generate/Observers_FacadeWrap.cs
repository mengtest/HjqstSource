﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Observers_FacadeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Observers.Facade), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("SendNotification", SendNotification);
		L.RegFunction("NotifyObservers", NotifyObservers);
		L.RegFunction("RegisterObserver", RegisterObserver);
		L.RegFunction("RemoveObserver", RemoveObserver);
		L.RegFunction("RemoveAllObserver", RemoveAllObserver);
		L.RegFunction("HasObserver", HasObserver);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendNotification(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, typeof(Observers.Facade), typeof(string)))
			{
				Observers.Facade obj = (Observers.Facade)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.SendNotification(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, typeof(Observers.Facade), typeof(string), typeof(object)))
			{
				Observers.Facade obj = (Observers.Facade)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendNotification(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, typeof(Observers.Facade), typeof(string), typeof(object), typeof(string)))
			{
				Observers.Facade obj = (Observers.Facade)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				string arg2 = ToLua.ToString(L, 4);
				obj.SendNotification(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Observers.Facade.SendNotification");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NotifyObservers(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Observers.Facade obj = (Observers.Facade)ToLua.CheckObject(L, 1, typeof(Observers.Facade));
			Observers.Interfaces.INotification arg0 = (Observers.Interfaces.INotification)ToLua.CheckObject(L, 2, typeof(Observers.Interfaces.INotification));
			obj.NotifyObservers(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterObserver(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Observers.Facade obj = (Observers.Facade)ToLua.CheckObject(L, 1, typeof(Observers.Facade));
			string arg0 = ToLua.CheckString(L, 2);
			System.Func<Observers.Interfaces.INotification,bool> arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (System.Func<Observers.Interfaces.INotification,bool>)ToLua.CheckObject(L, 3, typeof(System.Func<Observers.Interfaces.INotification,bool>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(System.Func<Observers.Interfaces.INotification,bool>), func) as System.Func<Observers.Interfaces.INotification,bool>;
			}

			obj.RegisterObserver(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveObserver(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Observers.Facade obj = (Observers.Facade)ToLua.CheckObject(L, 1, typeof(Observers.Facade));
			string arg0 = ToLua.CheckString(L, 2);
			System.Func<Observers.Interfaces.INotification,bool> arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (System.Func<Observers.Interfaces.INotification,bool>)ToLua.CheckObject(L, 3, typeof(System.Func<Observers.Interfaces.INotification,bool>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(System.Func<Observers.Interfaces.INotification,bool>), func) as System.Func<Observers.Interfaces.INotification,bool>;
			}

			obj.RemoveObserver(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAllObserver(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Observers.Facade obj = (Observers.Facade)ToLua.CheckObject(L, 1, typeof(Observers.Facade));
			obj.RemoveAllObserver();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasObserver(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Observers.Facade obj = (Observers.Facade)ToLua.CheckObject(L, 1, typeof(Observers.Facade));
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.HasObserver(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
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
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, Observers.Facade.Instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

