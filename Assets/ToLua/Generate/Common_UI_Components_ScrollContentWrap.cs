﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Common_UI_Components_ScrollContentWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Common.UI.Components.ScrollContent), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Init", Init);
		L.RegFunction("Reset", Reset);
		L.RegFunction("RefreshAllContentItems", RefreshAllContentItems);
		L.RegFunction("ScrollTo", ScrollTo);
		L.RegFunction("ScrollToEnd", ScrollToEnd);
		L.RegFunction("ScrollToEndByTime", ScrollToEndByTime);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("scrollRect", get_scrollRect, set_scrollRect);
		L.RegVar("rectTransform", get_rectTransform, set_rectTransform);
		L.RegVar("contentItemPrefab", get_contentItemPrefab, set_contentItemPrefab);
		L.RegVar("shouldDisablePrefab", get_shouldDisablePrefab, set_shouldDisablePrefab);
		L.RegVar("row", get_row, set_row);
		L.RegVar("col", get_col, set_col);
		L.RegVar("paddingTop", get_paddingTop, set_paddingTop);
		L.RegVar("paddingBottom", get_paddingBottom, set_paddingBottom);
		L.RegVar("paddingLeft", get_paddingLeft, set_paddingLeft);
		L.RegVar("paddingRight", get_paddingRight, set_paddingRight);
		L.RegVar("horizontalSpacing", get_horizontalSpacing, set_horizontalSpacing);
		L.RegVar("verticalSpacing", get_verticalSpacing, set_verticalSpacing);
		L.RegVar("onResetItem", get_onResetItem, set_onResetItem);
		L.RegVar("onInitComplete", get_onInitComplete, set_onInitComplete);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)ToLua.CheckObject(L, 1, typeof(Common.UI.Components.ScrollContent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			obj.Init(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)ToLua.CheckObject(L, 1, typeof(Common.UI.Components.ScrollContent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Reset(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshAllContentItems(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)ToLua.CheckObject(L, 1, typeof(Common.UI.Components.ScrollContent));
			obj.RefreshAllContentItems();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollTo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)ToLua.CheckObject(L, 1, typeof(Common.UI.Components.ScrollContent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.ScrollTo(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollToEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)ToLua.CheckObject(L, 1, typeof(Common.UI.Components.ScrollContent));
			obj.ScrollToEnd();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollToEndByTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)ToLua.CheckObject(L, 1, typeof(Common.UI.Components.ScrollContent));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.ScrollToEndByTime(arg0);
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
	static int get_scrollRect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			UnityEngine.UI.ScrollRect ret = obj.scrollRect;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scrollRect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rectTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			UnityEngine.RectTransform ret = obj.rectTransform;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rectTransform on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contentItemPrefab(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			UnityEngine.GameObject ret = obj.contentItemPrefab;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index contentItemPrefab on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shouldDisablePrefab(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			bool ret = obj.shouldDisablePrefab;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index shouldDisablePrefab on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_row(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			int ret = obj.row;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index row on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_col(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			int ret = obj.col;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index col on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_paddingTop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float ret = obj.paddingTop;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index paddingTop on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_paddingBottom(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float ret = obj.paddingBottom;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index paddingBottom on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_paddingLeft(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float ret = obj.paddingLeft;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index paddingLeft on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_paddingRight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float ret = obj.paddingRight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index paddingRight on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_horizontalSpacing(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float ret = obj.horizontalSpacing;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index horizontalSpacing on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_verticalSpacing(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float ret = obj.verticalSpacing;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index verticalSpacing on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onResetItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			Common.UI.Components.OnResetItem ret = obj.onResetItem;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onResetItem on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onInitComplete(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			Common.UI.Components.OnInitComplete ret = obj.onInitComplete;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onInitComplete on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scrollRect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			UnityEngine.UI.ScrollRect arg0 = (UnityEngine.UI.ScrollRect)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.ScrollRect));
			obj.scrollRect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scrollRect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rectTransform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.RectTransform));
			obj.rectTransform = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rectTransform on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_contentItemPrefab(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.contentItemPrefab = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index contentItemPrefab on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shouldDisablePrefab(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.shouldDisablePrefab = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index shouldDisablePrefab on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_row(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.row = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index row on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_col(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.col = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index col on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_paddingTop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.paddingTop = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index paddingTop on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_paddingBottom(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.paddingBottom = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index paddingBottom on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_paddingLeft(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.paddingLeft = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index paddingLeft on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_paddingRight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.paddingRight = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index paddingRight on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_horizontalSpacing(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.horizontalSpacing = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index horizontalSpacing on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_verticalSpacing(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.verticalSpacing = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index verticalSpacing on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onResetItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			Common.UI.Components.OnResetItem arg0 = (Common.UI.Components.OnResetItem)ToLua.CheckObject(L, 2, typeof(Common.UI.Components.OnResetItem));
			obj.onResetItem = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onResetItem on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onInitComplete(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Common.UI.Components.ScrollContent obj = (Common.UI.Components.ScrollContent)o;
			Common.UI.Components.OnInitComplete arg0 = (Common.UI.Components.OnInitComplete)ToLua.CheckObject(L, 2, typeof(Common.UI.Components.OnInitComplete));
			obj.onInitComplete = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onInitComplete on a nil value" : e.Message);
		}
	}
}

