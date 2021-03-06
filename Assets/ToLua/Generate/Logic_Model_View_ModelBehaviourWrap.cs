﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Logic_Model_View_ModelBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Logic.Model.View.ModelBehaviour), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("ClickBehavior", ClickBehavior);
		L.RegFunction("Rotate", Rotate);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("defaultSpeed", get_defaultSpeed, set_defaultSpeed);
		L.RegVar("stateNameHash", get_stateNameHash, set_stateNameHash);
		L.RegVar("CharacterEntity", get_CharacterEntity, null);
		L.RegVar("canRotate", null, set_canRotate);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClickBehavior(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Logic.Model.View.ModelBehaviour obj = (Logic.Model.View.ModelBehaviour)ToLua.CheckObject(L, 1, typeof(Logic.Model.View.ModelBehaviour));
			obj.ClickBehavior();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Rotate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Logic.Model.View.ModelBehaviour obj = (Logic.Model.View.ModelBehaviour)ToLua.CheckObject(L, 1, typeof(Logic.Model.View.ModelBehaviour));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Rotate(arg0);
			return 0;
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
	static int get_defaultSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Model.View.ModelBehaviour obj = (Logic.Model.View.ModelBehaviour)o;
			float ret = obj.defaultSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index defaultSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_stateNameHash(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Model.View.ModelBehaviour obj = (Logic.Model.View.ModelBehaviour)o;
			int ret = obj.stateNameHash;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index stateNameHash on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CharacterEntity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Model.View.ModelBehaviour obj = (Logic.Model.View.ModelBehaviour)o;
			Logic.Character.CharacterEntity ret = obj.CharacterEntity;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CharacterEntity on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Model.View.ModelBehaviour obj = (Logic.Model.View.ModelBehaviour)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.defaultSpeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index defaultSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_stateNameHash(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Model.View.ModelBehaviour obj = (Logic.Model.View.ModelBehaviour)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.stateNameHash = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index stateNameHash on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_canRotate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Logic.Model.View.ModelBehaviour obj = (Logic.Model.View.ModelBehaviour)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.canRotate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index canRotate on a nil value" : e.Message);
		}
	}
}

